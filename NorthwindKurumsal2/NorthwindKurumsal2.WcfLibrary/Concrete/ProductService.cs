using NorthwindKurumsal2.BII.Concrete;
using NorthwindKurumsal2.Dal.Concrete.EntityFramework;
using NorthwindKurumsal2.Entities;
using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        private ProductManager _productmanager = new ProductManager(new EfProductDal());

        public void Add(Product product)
        {
            _productmanager.Add(product);
        }

        public void Delete(int ProductId)
        {
            _productmanager.Delete(ProductId);
        }

        public Product Get(int ProductId)
        {
            return _productmanager.Get(ProductId);
        }

        public List<Product> GetAll()
        {
            return _productmanager.GetAll();
        }

        public void Update(Product product)
        {
            _productmanager.Update(product);
        }
    }
}
