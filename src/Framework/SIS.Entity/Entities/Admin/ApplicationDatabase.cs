using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities.Admin
{
    [Table("ApplicationDatabase")]
    public class ApplicationDatabase
    {
        [Key]
        public int Id { get; set; }
        public int? ServerId { get; set; }
        public string DatabaseName { get; set; }
        public int? ApplicationId { get; set; }
        public string DataVersion { get; set; }
        [NotMapped]
        public string ConnectionString { get; set; }


    }
}
