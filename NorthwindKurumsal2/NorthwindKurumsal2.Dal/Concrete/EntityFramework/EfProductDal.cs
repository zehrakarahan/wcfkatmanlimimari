using NorthwindKurumsal2.Dal.Abstract;
using NorthwindKurumsal2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        MvcDB db = new MvcDB();
        public void Add(Product entity)
        {
            db.Product.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int ProductId)
        {
            db.Product.Remove(db.Product.Where(x => x.ProductId == ProductId).FirstOrDefault());
        }

        public Product Get(int ProductId)
        {
            var veri2 = db.Product.Where(x => x.ProductId == ProductId).FirstOrDefault();
            return veri2;
        }

        public List<Product> GetAll()
        {
            var veriler = db.Product.ToList();
            return veriler;
        }

        public void Update(Product entity)
        {
            db.Product.AddOrUpdate(entity);
            db.SaveChanges();
        }
    }
}
