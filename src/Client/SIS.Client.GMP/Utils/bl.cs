using SIS.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.GMP.Utils
{
    public static class bl
    {
        public static SIS.Service.GMP.Repository.Repository _blcgmp;

        public static SIS.Service.GMP.Repository.Repository blcgmp
        {
            get
            {
                if (_blcgmp == null)
                {
                    _blcgmp = SIS.Client.Admin.bl.get_Repository_Gmp();
                }
                return _blcgmp;
            }
            set
            {
                _blcgmp = value;
            }
        }

        public static Screen GMP = new Screen();
    }
}
