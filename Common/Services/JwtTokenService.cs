using Common.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Common.Services
{
    public class JwtTokenService(IConfiguration configuration) : IJwtTokenService
    {
        public string Authenticate(string numeroDeTarjeta)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKeyBytes = Encoding.ASCII.GetBytes(configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("NumeroDeTarjeta", numeroDeTarjeta)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKeyBytes), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
