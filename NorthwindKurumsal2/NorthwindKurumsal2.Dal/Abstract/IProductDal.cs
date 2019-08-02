using NorthwindKurumsal2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.Dal.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();

        Product Get(int ProductId);

        void Add(Product entity);

        void Delete(int ProductId);

        void Update(Product entity);
    }
}
