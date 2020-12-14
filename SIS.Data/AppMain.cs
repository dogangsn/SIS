using SIS.Data.App;
using SIS.Data.DbConectionModel;
using SIS.Model.Models.GMP.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data
{
    public class AppMain
    {
        public static ConnectionDTO SqlConnection { get; set; }
        public static UsersDTO User { get; set; }

        public static bool GMPActive;
        public static bool HTPActive;
        public static int AppId;
        public static string AppName;

        public static List<AppIdView> List_AppIdView = new List<AppIdView>();
        public static int AplicationId = 2;


        public static bool NetworkConnected = true;


    }
}
