using SIS.Data.Managers;
using SIS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.blvalue
{
    public class AppMain
    {
        public static AppValue AppValue { get; set; }
        public static int AppId { get; set; }



        public static string CreateJwtToken(string name, string value)
        {
            string _value = value;
            IAuthService authService = new JWTService();
            IAuthContainerModel model = GetJWTContainerModel(name, value);

            string token = authService.GenerateToken(model);
            if (!string.IsNullOrEmpty(token))
            {
                _value = token;
            }

            return _value;

        }
        private static JWTContainerModel GetJWTContainerModel(string name, string value)
        {
            return new JWTContainerModel
            {
                Claims = new List<ClaimDto>
                {
                    new ClaimDto( name,value)
                }
            };
        }


    }
}
