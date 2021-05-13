using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data.App
{
    public class LoginUser
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string HashPassword { get; set; }
        public string LangCode { get; set; }
        public string RoleCode { get; set; }
        public string SecCode { get; set; }
    }
}
