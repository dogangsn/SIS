using SIS.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data.Managers
{
    public interface IAuthService
    {
        string SecretKey { get; set; }
        bool IsTokenValid(string token);

        string GenerateToken(IAuthContainerModel model);

        List<ClaimDto> GetTokenClaim(string token);

        string GetConnectionStringFromToken(string token);
    }
}
