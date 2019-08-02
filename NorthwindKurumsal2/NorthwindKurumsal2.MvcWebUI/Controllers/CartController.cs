using NorthwindKurumsal2.Entities;
using NorthwindKurumsal2.Interfaces;
using NorthwindKurumsal2.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace NorthwindKurumsal2.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productservice;
        List<SepetUrun> sepet;
        List<CartUrunler> sepet2;

        public CartController(IProductService productservice)
        {
            _productservice = productservice;
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
       
    }
}