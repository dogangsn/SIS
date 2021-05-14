using SIS.Data.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.Admin
{
    public abstract class AppService
    {
        public abstract void CreateBlc();
        public abstract List<SIS.Data.Admin.UserCompanyRight> GetUserCompanyRights(SIS.Data.App.GetValue _GetValue);

        public abstract string GetHashPassword(string password);

        public abstract LoginUser GetLoginUser(GetValue _GetValue);

        public abstract void Login(GetValue _GetValur);

    }
}
