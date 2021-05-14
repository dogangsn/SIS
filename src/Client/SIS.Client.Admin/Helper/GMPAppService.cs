using SIS.Client.blvalue;
using SIS.Data.Admin;
using SIS.Data.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.Admin.Helper
{
    public class GMPAppService : AppService
    {
        public override void CreateBlc()
        {
            bl.blcGmp = new SIS.Service.GMP.Repository.Repository(AppMain.AppValue.RunningLocalApp, AppMain.AppValue.ApiUrlApp);
        }
        public override string GetHashPassword(string password)
        {
            return SIS.Client.Admin.Tool.ConvertStringToMD5(password);
        }
        public override LoginUser GetLoginUser(GetValue _GetValue)
        {
            return bl.blcGmp.Run<SIS.Service.GMP.Service.System.SystemService, SIS.Data.App.LoginUser>(r => r.Get_LoginUsersByCode(_GetValue));
        }

        public override List<UserCompanyRight> GetUserCompanyRights(GetValue _GetValue)
        {
            return bl.blcGmp.Run<SIS.Service.GMP.Service.Admin.AdminGmpService, List<UserCompanyRight>>(r => r.get_List_UserCompanyRight(_GetValue));
        }

        public override void Login(GetValue _GetValue)
        {
            AppMain.AppValue.Users_GMP = bl.blcGmp.Run<SIS.Service.GMP.Service.System.SystemService, Entity.Entities.GMP.Users>(r => r.Get_UsersByCode(_GetValue));
        }

    }
}
