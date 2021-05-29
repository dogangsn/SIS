using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities.GMP
{
    public class ProductOperation
    {
        [Key]
        public int RecId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int? SinifId { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? VatRate { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? CriticalStock { get; set; }
        public int? BonusPercent { get; set; }
        public int? PrimPercent { get; set; }
        public string Remark { get; set; }
        public int? UnitId { get; set; }
        public TimeSpan? OperationTime { get; set; }
        public byte[] Photo { get; set; }
        public int? Type { get; set; }
        public bool? Deleted { get; set; }
        public string DeletedUser { get; set; }
        public string RecordUser { get; set; }
    }
}
