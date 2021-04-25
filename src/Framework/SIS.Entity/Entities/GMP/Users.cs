﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity.Entities.GMP
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string note { get; set; }
        public DateTime? date { get; set; }
        public bool? Active { get; set; }
        public string HaspPassword { get; set; }
        public string Email { get; set; }
        public string DefaultTheme { get; set; }
        public string DefaultTheme2 { get; set; }
        public string KartId { get; set; }
    }
}
