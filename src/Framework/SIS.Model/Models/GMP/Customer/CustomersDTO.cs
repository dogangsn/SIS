using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Model.Models.GMP.Customer
{
    public class CustomersDTO
    {
        public int RecId { get; set; }
        public string TCKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Cinsiyeti { get; set; }
        public DateTime? RecordDate { get; set; }
        public string Meslek { get; set; }
        public string CalistigiYer { get; set; }
        public string Konu { get; set; }
        public string Boy { get; set; }
        public string Kilo { get; set; }
        public bool? IsEvAdresi { get; set; } = false;
        public bool? IsİsAdresi { get; set; } = false;
        public string EvAdress { get; set; }
        public string EvAdresIlce { get; set; }
        public string EvAdressIl { get; set; }
        public string IsAdres { get; set; }
        public string IsAdresIl { get; set; }
        public string IsAdresIlce { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public string CepTel2 { get; set; }
        public string IsTel { get; set; }
        public string Eposta { get; set; }
        public string Fax { get; set; }
        public bool? CebinizeMesajGelsin { get; set; } = false;
        public byte[] Photo { get; set; }
        public string Remark { get; set; }
        public string FaturaAdress { get; set; }
        public string FaturaUnvan { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public int? CompanyRecId { get; set; }
        public bool? IsArsiv { get; set; } = false;
        public bool? Deleted { get; set; } = false;
        public string RecordUser { get; set; }
    }
}
