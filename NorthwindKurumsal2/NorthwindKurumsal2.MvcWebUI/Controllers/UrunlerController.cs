using NorthwindKurumsal2.Interfaces;
using NorthwindKurumsal2.MvcWebUI.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static NorthwindKurumsal2.MvcWebUI.App_Classes.Sepet;

namespace NorthwindKurumsal2.MvcWebUI.Controllers
{
    public class UrunlerController : Controller
    {
        private IProductService _productservice;

        public UrunlerController(IProductService productservice)
        {
            _productservice = productservice;
        }
        // GET: Urunler

        public ActionResult Index()
        {
           
            return View(_productservice.GetAll());
        }
        public void SepeteEklemeKismi(int id)
        {
            SepetItem si = new SepetItem();
            Entities.Product product = _productservice.GetAll().FirstOrDefault(x=>x.ProductId==id);
            si.Product = product;
            si.Adet = 1;
            Sepet s = new Sepet();
            s.SepeteEkle(si);

        }
      
        public PartialViewResult MiniSepetWidget()
        {
            if (HttpContext.Session["AktifSepet"] != null)
            {
                return PartialView(HttpContext.Session["AktifSepet"]);
            }
            else
            {
                return PartialView();
            }

        }
    }
}