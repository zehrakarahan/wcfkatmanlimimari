using NorthwindKurumsal2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.Dal.Abstract
{
    public interface IKategoriDal
    {
        List<Category> GetAll();

        Category Get(int KategoriId);

        void Add(Category entity);

        void Delete(int KategoriId);

        void Update(Category entity);
    }
}
