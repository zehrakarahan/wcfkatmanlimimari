using NorthwindKurumsal2.Entities;
using NorthwindKurumsal2.Interfaces;
using NorthwindKurumsal2.MvcWebUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace NorthwindKurumsal2.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private IProductService _productservice;

        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }
     
        public ActionResult Index(int? page,int category=0)
        {
            var deger = _productservice.GetAll().Where(p=>p.CategoryId==category || category==0).ToList();
           var gec = deger.ToPagedList(page ?? 1,5);
            return View(gec);
        }

      
    }
}