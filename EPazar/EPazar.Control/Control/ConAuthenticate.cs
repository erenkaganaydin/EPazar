using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using EPazar.Control.Interface;

namespace EPazar.Control.Control
{
    public class ConAuthenticate : IAuthenticate
    {
        private readonly IDictionary<string, string> keyValues = new Dictionary<string, string>
        {{"ttl","wdtj123"},{"t.t.l","123wdtj"} };

        private readonly string key;

        public ConAuthenticate(string key)
        {
            this.key = key;
        }

        public string Authenticate(string userName, string password)
        {
            if (!keyValues.Any(x => x.Key == userName && x.Value == password))
                return null;

            JwtSecurity(userName, out JwtSecurityTokenHandler tokenHanler, out SecurityTokenDescriptor tokenDescription);

            var token = tokenHanler.CreateToken(tokenDescription);
            return tokenHanler.WriteToken(token);
        }

        private void JwtSecurity(string userName, out JwtSecurityTokenHandler tokenHanler, out SecurityTokenDescriptor tokenDescription)
        {
            tokenHanler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);

            tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,userName)
                }),
                Expires = DateTime.UtcNow.AddYears(1),

                SigningCredentials = new SigningCredentials
                                         (new SymmetricSecurityKey(tokenKey),
                                         SecurityAlgorithms.HmacSha512Signature),
            };
        }
    }
}