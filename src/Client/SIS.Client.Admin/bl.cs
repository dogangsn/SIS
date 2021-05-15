using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.Admin
{
    public class bl
    {
        public static SIS.Client.Admin.pl pladmin = new pl();
        public static SIS.Service.Admin.Repository blcAdmin;
        public static AppService AppService { get; set; }
        public static SIS.Service.Admin.Repository get_Repository_Admin()
        {
            return blcAdmin;
        }

        public static SIS.Data.App.GetValue get_GetValue()
        {
            Data.App.GetValue _GetValue = new Data.App.GetValue();
            return _GetValue;

        }

        public static SIS.Client.Admin.Message message = new Message();

        public static SIS.Service.GMP.Repository.Repository blcGmp { get; set; }
        public static void set_Repository_Gmp(SIS.Service.GMP.Repository.Repository _Repository)
        {
            blcGmp = _Repository;
        }

        public static SIS.Service.GMP.Repository.Repository get_Repository_Gmp()
        {
            return blcGmp;
        }


    }
}
