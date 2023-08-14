using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using Microsoft.IdentityModel.Tokens;
using CommonRes.DTO;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi1.Controllers;

[AllowAnonymous]
[Route("api/[controller]")]
[ApiController]
public class IdentityController : ControllerBase
{
  //# for injection
  ILogger<IdentityController> _logger;
  IConfiguration _config;

  public IdentityController(ILogger<IdentityController> logger, IConfiguration config)
  {
    _logger = logger;
    _config = config;
  }

  /// <seealso cref="https://www.youtube.com/watch?v=mgeuh8k3I4g&t=2s&ab_channel=NickChapsas"/>
  /// <seealso cref="https://github.com/doggy8088/AspNetCore6JwtAuthDemo/blob/main/JwtHelpers.cs"/>
  [SwaggerResponse(200, type: typeof(String))]
  [SwaggerResponse(400, type: typeof(string))]
  [HttpPost("[action]")]
  public IActionResult GenerateToken([FromBody] TokenGenerationRequest request)
  {
    try
    {
      var key = Encoding.ASCII.GetBytes(_config["JwtSettings:SigningKey"]);

      var claims = new List<Claim>
      {
        new(ClaimTypes.Name, "MyName"),
        new (JwtRegisteredClaimNames.Name, "showmethemoney"),
        new (JwtRegisteredClaimNames.GivenName, "Show me the money"), // 顯示名稱
        new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new (JwtRegisteredClaimNames.Sub, request.Email),
        new (JwtRegisteredClaimNames.Email, request.Email),
        new ("userid", request.UserId.ToString()),
        new (ClaimTypes.Role, "Staff"),
        new (ClaimTypes.Role, "DEMO001"),
        new (ClaimTypes.Role, "DEOM002"),
        new (ClaimTypes.Role, "DEMO003")
      };

      if (request.CustomClaims != null)
      {
        foreach (var claimPair in request.CustomClaims)
        {
          var claim = new Claim(claimPair.Key, claimPair.Value, ClaimValueTypes.String);
          claims.Add(claim);
        }
      }

      var tokenHandler = new JwtSecurityTokenHandler();
      var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(claims),
        Expires = DateTime.UtcNow.Add(TimeSpan.FromMinutes(_config.GetValue<double>("JwtSettings:TokenLifetimeMinutes"))),
        Issuer = _config["JwtSettings:Issuer"],
        Audience = _config["JwtSettings:Audience"],
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      });

      var jwt = tokenHandler.WriteToken(token);

      return Ok(jwt);
    }
    catch (Exception ex)
    {
      //return Unauthorized(ex.Message);
      return BadRequest(ex.Message);
    }
  }
}
