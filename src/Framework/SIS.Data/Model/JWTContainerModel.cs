using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data.Model
{
    public class JWTContainerModel : IAuthContainerModel
    {
        public JWTContainerModel()
        {
            Claims = new List<ClaimDto>();

        }
        public string SecretKey { get; set; } = "KodyazılımTarafındanUretilenGizliKey";
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;
        public int ExpireMinutes { get; set; } = 10080; // 7 Days
        public List<ClaimDto> Claims { get; set; }
    }
}
