using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities.GMP
{
    public class SessionPackage
    {
        [Key]
        public int RecId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int? SinifId { get; set; }
        public int? SessionRepat { get; set; }
        public int? UnitId { get; set; }
        public decimal? PackageCost { get; set; }
        public decimal? SalePrice { get; set; }
        public int? VatRatio { get; set; }
        public DateTime? RecordDate { get; set; }
        public TimeSpan? OperationTime { get; set; }
        public int? Bonus { get; set; }
        public int? Prim { get; set; }
        public string Remark { get; set; }
        public bool? Deleted { get; set; }
        public string RecordUser { get; set; }
        public string DeletedUser { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeUser { get; set; }
    }
}
