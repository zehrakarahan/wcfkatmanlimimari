using NorthwindKurumsal2.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindKurumsal2.Entities;
using System.Data.Entity.Migrations;

namespace NorthwindKurumsal2.Dal.Concrete.EntityFramework
{
    public class EfKategoriDal : IKategoriDal
    {
        MvcDB db = new MvcDB();
        public void Add(Category entity)
        {
            db.Category.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int KategoriId)
        {
            db.Category.Remove(db.Category.Where(x=>x.CategoryId==KategoriId).FirstOrDefault());
        }

        public Category Get(int KategoriId)
        {
            return db.Category.Where(x => x.CategoryId == KategoriId).FirstOrDefault();
        }

        public List<Category> GetAll()
        {
            return db.Category.ToList();
        }

        public void Update(Category entity)
        {
            db.Category.AddOrUpdate(entity);
            db.SaveChanges();
        }
    }
}
