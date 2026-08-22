using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationUI.Tools;

public class JwtTokenTool
{
    public static string GenerateJwtToken(byte[] keyBytes, IdentityUser user, DateTime expires, string audience)
    {
        try
        {
            var securityKey = new SymmetricSecurityKey(keyBytes);
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, user.UserName ?? string.Empty),
                new(ClaimTypes.Email, user.Email ?? string.Empty),
                new(JwtRegisteredClaimNames.Sub, user.Id ?? string.Empty),
                new(ClaimTypes.Role, user.NormalizedUserName ?? string.Empty),
            };

            if (!string.IsNullOrWhiteSpace(user.PhoneNumber))
            {
                claims.Add(new Claim(ClaimTypes.MobilePhone, user.PhoneNumber));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expires,
                SigningCredentials = credential,
                Audiences = { audience }
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);

            return jwtToken;
        }
        catch (ArgumentException)
        {
            throw;
        }
    }
}
