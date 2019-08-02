using NorthwindKurumsal2.Dal.Abstract;
using NorthwindKurumsal2.Entities;
using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.BII.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal product)
        {
            this._productDal = product;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }


        public void Delete(int ProductId)
        {
            _productDal.Delete(ProductId);
        }


        public void Update(Product product)
        {
            _productDal.Update(product);
        }



        public Product Get(int ProductId)
        {
            return _productDal.Get(ProductId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }

}
