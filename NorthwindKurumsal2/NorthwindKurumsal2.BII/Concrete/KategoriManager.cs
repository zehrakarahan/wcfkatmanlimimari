using NorthwindKurumsal2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindKurumsal2.Entities;
using NorthwindKurumsal2.Dal.Abstract;

namespace NorthwindKurumsal2.BII.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriler)
        {
            this._kategoriDal = kategoriler;
        }
        public void Add(Category kategori)
        {
            _kategoriDal.Add(kategori);
        }

        public void Delete(int KategoriId)
        {
            _kategoriDal.Delete(KategoriId);
        }

        public Category Get(int KategoriId)
        {
           return _kategoriDal.Get(KategoriId);
        }

        public List<Category> GetAll()
        {
            return _kategoriDal.GetAll();
        }

        public void Update(Category kategori)
        {
            _kategoriDal.Update(kategori);
        }
    }
}
