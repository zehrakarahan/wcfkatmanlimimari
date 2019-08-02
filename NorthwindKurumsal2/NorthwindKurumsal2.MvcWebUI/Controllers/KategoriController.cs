using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindKurumsal2.MvcWebUI.Controllers
{
    public class KategoriController : Controller
    {
        private IKategoriService _categoriservice;

        public KategoriController(IKategoriService categoriservice)
        {
            _categoriservice = categoriservice;
        }
        public PartialViewResult Index()
        {
            return PartialView(_categoriservice.GetAll());
        }
    }
}