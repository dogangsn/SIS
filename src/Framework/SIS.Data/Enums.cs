using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data
{
    class Enums
    {
    }

    public enum AdminAppType : int
    {
        GMP = 1,
        HTP = 2,
        GYM = 3,
        RAC = 4,


    }

    public enum FormOpenType
    {
        View = -1,
        New = 0,
        Copy = 1,
        Edit = 2,
        Non = 9
    }



}
