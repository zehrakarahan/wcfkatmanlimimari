using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindKurumsal2.MvcWebUI.Models
{
    public class SepetUrun
    {
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }
}