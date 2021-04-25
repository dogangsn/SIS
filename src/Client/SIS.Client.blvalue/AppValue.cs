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

        public string ConAdminFirst { get; set; }

        public ConnectionDTO AdminConnectionDTO;

        public ConnectionDTO DbAdminConnectionDTO;

        public  bool GMPActive;
        public  bool HTPActive;
        public  int AppId;
        public  string AppName;
    }
}
