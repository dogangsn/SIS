using SIS.Client.Admin.Helper;
using SIS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.Admin
{
    public class AppServiceFactory
    {
        public static AppService CreateApp(AdminAppType appType)
        {
            AppService appService;

            switch (appType)
            {
                case AdminAppType.GMP:
                    appService = new GMPAppService();
                    break;

                default:
                    appService = new GMPAppService();
                    break;
            }

            return appService;
        }
    }
}
