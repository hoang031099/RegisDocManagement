using RegisDocManagement.Data;
using RegisDocManagement.Entities;
using RegisDocManagement.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.IO;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace RegisDocManagement.Services
{
    public class Service : IService
    {
        public string AuthorizeUser(User u)
        {
            using (VNNICdb db = new())
            {
                try
                {
                    var user = db.Users.Where(x => x.Username == u.Username && x.Password == u.Password).FirstOrDefaultAsync();
                    if (user.Result == null)
                    {
                        return "";
                    }

                    var issuer = Configuration.issuer;
                    var audience = Configuration.audience;
                    var key = Encoding.ASCII.GetBytes(Configuration.key);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new[]
                        {
                        //new Claim("Id", Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Sub, u.Username),
                        //new Claim(JwtRegisteredClaimNames.Email, user.UserName),
                        //new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                    }),
                        Expires = DateTime.UtcNow.AddMinutes(30),
                        Issuer = issuer,
                        Audience = audience,
                        SigningCredentials = new SigningCredentials
                        (new SymmetricSecurityKey(key),
                        SecurityAlgorithms.HmacSha512Signature)
                    };

                    var tokenHandler = new JwtSecurityTokenHandler();
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var jwtToken = tokenHandler.WriteToken(token);
                    var stringToken = tokenHandler.WriteToken(token);
                    return stringToken;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }    

        public async Task AddNewDomain(Domain d)
        {
            using (VNNICdb db = new())
            {
                try
                {
                    var result = db.Domains.Add(d);
                    await db.SaveChangesAsync();

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
