using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities
{
    [Table("Personels")]
    public class Personels
    {
        [Key]
        public int RecId { get; set; }
        public string VergiDairesi { get; set; }
        public string TCKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public string Görevi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Eposta { get; set; }
        public string CepTel { get; set; }
        public string EvTel { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string Adress { get; set; }
        public decimal? ikramiye { get; set; }
        public decimal? maas { get; set; }
        public byte[] Photo { get; set; }
        public int? CompanyId { get; set; }

    }
}
