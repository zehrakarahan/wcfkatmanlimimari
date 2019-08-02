using Ninject;
using NorthwindKurumsal2.BII.Concrete;
using NorthwindKurumsal2.Dal.Concrete.EntityFramework;
using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NorthwindKurumsal2.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
           // AddBIIBindings();
            AddServiceBindings();
        }

        private void AddBIIBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("product", new EfProductDal());

            _ninjectKernel.Bind<IKategoriService>().To<KategoriManager>().WithConstructorArgument("kategoriler", new EfKategoriDal());

            
        }
        public void AddServiceBindings()
        {
            _ninjectKernel.Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null :(IController) _ninjectKernel.Get(controllerType);
        }
    }
}