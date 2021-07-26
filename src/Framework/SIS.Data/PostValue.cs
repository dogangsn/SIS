using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Data
{
    public class PostValue
    {
        public int? Id { get; set; }
        public int? Id2 { get; set; }
        public int? Id3 { get; set; }
        public string IdStr { get; set; }
        public string IdStr2 { get; set; }
        public string IdStr3 { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyCode { get; set; }
        public string UserCode { get; set; }
        public string FormName { get; set; }
        public string PcName { get; set; }
        public string PcUserName { get; set; }
        public string PcTerminalName { get; set; }
        public string Period { get; set; }
        public DateTime? HotelDate { get; set; }
        public string ConStr { get; set; } = "";
        public string Email { get; set; }
        public string CompanyTaxNo { get; set; }
    }
}
