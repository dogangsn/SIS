using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities.Admin
{
    [Table("FormLayouts")]
    public class FormLayouts
    {
        [Key]
        public int Id { get; set; }
        public string UserCode { get; set; }
        public int ApplicationId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public byte[] Layout { get; set; }
    }
}
