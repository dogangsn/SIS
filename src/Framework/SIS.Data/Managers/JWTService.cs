using Microsoft.IdentityModel.Tokens;
using SIS.Data.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data.Managers
{
    public class JWTService : IAuthService
    {
        public JWTService()
        {

        }


        #region Private Methods
        private SecurityKey GetSymmetricSecurityKey()
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(SecretKey);
            string base64 = Convert.ToBase64String(byt);
            byte[] symmetricKey = Convert.FromBase64String(base64);
            return new SymmetricSecurityKey(symmetricKey);
        }

        private SymmetricSecurityKey GetSymmetricSecurityKey2()
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(SecretKey);
            string base64 = Convert.ToBase64String(byt);
            //byte[] symmetricKey = Convert.FromBase64String(base64);
            //return new SymmetricSecurityKey(symmetricKey);
            //"SecretKeySecretKeySecretKeySecretKeySecretKeySecretKeySecretKeyS"
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));

            //string sec1 = "ProEMLh5e_qnzdNU";

            //var securityKey1 = new SymmetricSecurityKey(Encoding.Default.GetBytes(sec1));
            return key;
        }
        private TokenValidationParameters GetTokenValidationParameters()
        {
            return new TokenValidationParameters()
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = GetSymmetricSecurityKey(),
                TokenDecryptionKey = GetSymmetricSecurityKey2()
            };
        }
        #endregion


        #region Public Methods
        public string SecretKey { get; set; } = "KodyazılımTarafındanUretilenGizliKey";


        private Claim[] GetClaims(List<ClaimDto> claimsDto)
        {
            var claims = claimsDto.Select(x => new Claim(x.Type, x.Value)).ToArray();
            return claims;
        }


        private List<ClaimDto> GetClaimsDto(Claim[] claimsDto)
        {
            var claims = claimsDto.Select(x => new ClaimDto(x.Type, x.Value)).ToList();
            return claims;
        }


        public string GenerateToken(IAuthContainerModel model)
        {
            if (model == null || model.Claims == null || model.Claims.Count == 0)
                throw new ArgumentException("Arguments to create token  are not valid");


            var ep = new EncryptingCredentials(
                    GetSymmetricSecurityKey2(),
                   JwtConstants.DirectKeyUseAlg,// SecurityAlgorithms.Aes128KW,
                    SecurityAlgorithms.Aes128CbcHmacSha256);


            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(GetClaims(model.Claims)),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToInt32(model.ExpireMinutes)),
                SigningCredentials = new SigningCredentials(GetSymmetricSecurityKey(), model.SecurityAlgorithm),
                EncryptingCredentials = ep//new EncryptingCredentials(GetSymmetricSecurityKey2(), model.SecurityAlgorithm),
            };

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            SecurityToken securityToken = handler.CreateToken(securityTokenDescriptor);
            string token = handler.WriteToken(securityToken);
            return token;
        }




        public List<ClaimDto> GetTokenClaim(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new NotImplementedException();

            TokenValidationParameters parameters = GetTokenValidationParameters();
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            try
            {
                ClaimsPrincipal tokenValid = handler.ValidateToken(token, parameters, out SecurityToken validatedTOken);

                return GetClaimsDto(tokenValid.Claims.ToArray());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool IsTokenValid(string token)
        {
            if (string.IsNullOrEmpty(token))
                throw new ArgumentException("Given token is null or empty");

            TokenValidationParameters tokenValidationParameters = GetTokenValidationParameters();

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            try
            {
                ClaimsPrincipal tokenValid = handler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }



        }
        #endregion


        public string GetConnectionStringFromToken(string token)
        {
            string connection = token;
            try
            {
                var claims = GetTokenClaim(token);
                if (claims.Any())
                {
                    connection = claims.FirstOrDefault(x => x.Type.Equals("connection")).Value;
                }
            }
            catch (Exception ex)
            {


            }
            return connection;
        }

    }
}
