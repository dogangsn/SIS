﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data.Admin
{
    public class UserCompanyRight
    {
        public int CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public string CompanyAlias { get; set; }
    }
}
