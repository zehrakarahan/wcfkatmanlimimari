using NorthwindKurumsal2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindKurumsal2.MvcWebUI.App_Classes
{
    public  class Sepet
    {

        public List<SepetItem> urunler = new List<SepetItem>();

        public List<SepetItem> Urunler
        {
            get
            {
                return urunler;
            }
            set
            {
                urunler = value;
            }
        }
        public decimal Toplamtutar
        {
            get
            {
                return Urunler.Sum(x => x.Tutar);
            }
        }

        public void SepeteEkle(SepetItem si)
        {
            if(HttpContext.Current.Session["AktifSepet"]!=null)
            {
                Sepet s = (Sepet)HttpContext.Current.Session["AktifSepet"];
                if(s.Urunler.Any(x=>x.Product.ProductId==si.Product.ProductId))
                {
                    s.Urunler.FirstOrDefault(x => x.Product.ProductId == si.Product.ProductId).Adet++;
                }
                else
                {
                    s.Urunler.Add(si);
                }
            }
            else
            {
                Sepet s = new Sepet();
                s.Urunler.Add(si);
                HttpContext.Current.Session["AktifSepet"] = s;
            }

        }

        public class SepetItem
        {
            public Product Product { get; set; }

            public int Adet { get; set; }

            public decimal Tutar
            {
                get
                {
                    return Product.Price * Adet;
                }
            }
        }
    }
}