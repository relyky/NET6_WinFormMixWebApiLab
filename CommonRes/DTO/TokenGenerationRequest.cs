using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonRes.DTO;

public class TokenGenerationRequest
{
  public Guid UserId { get; set; }
  public string Email { get; set; } = string.Empty;
  public Dictionary<string, string>? CustomClaims { get; set; }
}
