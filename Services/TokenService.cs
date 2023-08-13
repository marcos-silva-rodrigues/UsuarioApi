using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UsuarioApi.Data;

namespace UsuarioApi.Services
{
    public class TokenService
    {
        private IConfiguration _configuration;
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateToken(Usuario usuario)
        {
            Claim[] claims = new Claim[]
            { 
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id),
                new Claim(ClaimTypes.DateOfBirth, usuario.DataNascimento.ToString()),
                new Claim("loginTimestamp", DateTime.UtcNow.ToString())
            };

            var chave = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    _configuration["SymmetricSecurityKey"]
                    ));
            var signingCredentiasl = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddMinutes(10),
                claims: claims,
                signingCredentials: signingCredentiasl);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}