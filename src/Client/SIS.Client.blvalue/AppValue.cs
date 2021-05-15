using SIS.Data.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.blvalue
{
    public class AppValue
    {
        public bool CloudLicense { get; set; } = false;

        public string ConAdmin { get; set; }
        public string CustomerGuidId { get; set; } = Guid.Empty.ToString();
        public bool ForceUseLocal { get; set; } = false;
        public bool RunningLocalAdmin { get; set; }
        public string ApiUrlAdmin { get; set; }
        public string ConAdminFirst { get; set; }
        public string UserCode { get; set; }
        public string ConApp { get; set; }
        public bool RunningLocalApp { get; set; }
        public string ApiUrlApp { get; set; }

        public string Language { get; set; } = "En";

        public ConnectionDTO AdminConnectionDTO;

        public ConnectionDTO DbAdminConnectionDTO;

        public  bool GMPActive;
        public  bool HTPActive;
        public  bool APTActive;
        public  int AppId;
        public  string AppName;

        public SIS.Entity.Entities.GMP.Users Users_GMP;



    }
}
