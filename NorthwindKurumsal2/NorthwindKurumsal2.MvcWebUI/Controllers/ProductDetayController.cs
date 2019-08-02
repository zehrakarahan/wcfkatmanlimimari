using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindKurumsal2.MvcWebUI.Controllers
{
    public class ProductDetayController : Controller
    {
        // GET: ProductDetay
        private IProductService _productservice;

        public ProductDetayController(IProductService productservice)
        {
            _productservice = productservice;
        }
        public ActionResult Detail(int id)
        {
            var db = _productservice.Get(id);
            return View(db);
        }
    }
}