using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AuthenticationData;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationUI.Tools;

public class JwtTokenTool
{
    public static string GenerateJwtToken(byte[] keyBytes, Login login, DateTime expires, string audience)
    {
        try
        {
            var securityKey = new SymmetricSecurityKey(keyBytes);
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                [
                    new Claim(ClaimTypes.Name, login.Vorname),
                    new Claim(ClaimTypes.DateOfBirth, login.Geburtsdatum.ToString("dd.MM.yyyy")),
                    new Claim(ClaimTypes.Surname, login.Name),
                    new Claim(ClaimTypes.Email, login.Email),
                    new Claim(ClaimTypes.Country, login.Ort),
                    new Claim(ClaimTypes.PostalCode, $"{login.Postleitzahl}")
                ]),
                Expires = expires,
                SigningCredentials = credential,
                Audiences = { audience }
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);

            return jwtToken;
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
