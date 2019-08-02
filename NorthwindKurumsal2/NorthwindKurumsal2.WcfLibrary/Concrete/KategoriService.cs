using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindKurumsal2.Entities;
using NorthwindKurumsal2.BII.Concrete;
using NorthwindKurumsal2.Dal.Concrete.EntityFramework;

namespace NorthwindKurumsal2.WcfLibrary.Concrete
{
    public class KategoriService : IKategoriService
    {
        private KategoriManager _kategorimanager = new KategoriManager(new EfKategoriDal());
        public void Add(Category kategori)
        {
            _kategorimanager.Add(kategori);
        }

        public void Delete(int KategoriId)
        {
            _kategorimanager.Delete(KategoriId);
        }

        public Category Get(int KategoriId)
        {
            return _kategorimanager.Get(KategoriId);
        }

        public List<Category> GetAll()
        {
            return _kategorimanager.GetAll();
        }

        public void Update(Category kategori)
        {
            _kategorimanager.Update(kategori);
        }
    }
}
