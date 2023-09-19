using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//§§ Add services to the container. ===========================================

//## for Authentication & Authorization
builder.Services.AddAuthentication(option =>
{
  option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
  option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
  option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
  option.TokenValidationParameters = new TokenValidationParameters
  {
    ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
    ValidAudience = builder.Configuration["JwtSettings:Audience"],
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration["JwtSettings:SigningKey"])),
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
  };
});
//builder.Services.AddAuthorization(option =>
//{
//  option.AddPolicy(IdentityAttr.AdminPolicyName, p =>
//    p.RequireClaim(IdentityAttr.AdminClaimName, "true"));
//});

builder.Services.AddControllers(opt =>  // or AddMvc()
{
  //## 禁止自動把 HTTP Response 為 null 時轉換成 204 NoContent。因為 System.Text.Json 無法對 204 NoContent 解序列化！
  // 此設定應該只適用於 Web API。
  // remove formatter that turns nulls into 204 - No Content responses
  opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//§§ Configure the HTTP request pipeline. =====================================
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//## for Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
