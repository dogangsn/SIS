﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Model.Models.GMP.Definitions
{
    public class CompanyDTO
    {
        public int RecId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public byte[] Logo { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string BulvarCadde { get; set; }
        public int? TelNo { get; set; }
        public string BinaAdi { get; set; }
        public string BinaNo { get; set; }
        public string MahalleSemt { get; set; }
        public string Sehir { get; set; }
        public int? PostaKodu { get; set; }
        public string Ulke { get; set; }
    }
}
