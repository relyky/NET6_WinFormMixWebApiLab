using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi1.Models;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class RequiresClaimAttribute : Attribute, IAuthorizationFilter
{
  readonly string _claimName;
  readonly string _claimValue;

  public RequiresClaimAttribute(string claimName, string claimValue)
  {
    _claimName = claimName;
    _claimValue = claimValue;
  }

  public void OnAuthorization(AuthorizationFilterContext context)
  {
    if(!context.HttpContext.User.HasClaim(_claimName, _claimValue))
    {
      context.Result = new ForbidResult(); // 授權不足
    }
  }
}

/// <summary>
/// 登入與驗證相關屬性設定
/// </summary>
public class IdentityAttr
{
  public const string AdminClaimName = "admin";
  public const string AdminPolicyName = "Admin";
}