using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FirstAPiApp.Services
{
    public class TokenService : ITokenService
    {
        readonly byte[] _key;
        public TokenService(IConfiguration configuration)
        {
            _key = Encoding.UTF8.GetBytes(configuration["TokenKey"].ToString());
        }

        public async Task<string> GenerateToken(User user)
        {
            List<Claim> claims = new List<Claim>()
           {
               new Claim(ClaimTypes.Email,user.Username)
           };
            var symmetricKey = new SymmetricSecurityKey(_key);
            var credentials = new SigningCredentials(symmetricKey,SecurityAlgorithms.HmacSha256); ;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var myToken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(myToken);
            return token;
        }
    }
}
