using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities.Admin
{
    [Table("ApplicationServer")]
    public class ApplicationServer
    {
        [Key]
        public int Id { get; set; }
        public string Server { get; set; }
        public string ServerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool? Mask { get; set; }
        public string ApiLocal { get; set; } = "";
        public string ApiNet { get; set; } = "";

        public string ApiJob { get; set; } = "";

        public bool? ServerCloude { get; set; } = false;

        [NotMapped]
        public List<ApplicationDatabase> ApplicationDatabase { get; set; }

        [NotMapped]
        public string ConnectionString { get; set; }

        [NotMapped]
        public string InvoiceConnection { get; set; }
    }
}
