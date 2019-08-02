using NorthwindKurumsal2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindKurumsal2.Interfaces
{
    [ServiceContract]
    public interface IKategoriService
    {
        [OperationContract]
        List<Category> GetAll();
        [OperationContract]
        Category Get(int KategoriId);
        [OperationContract]
        void Add(Category kategori);
        [OperationContract]
        void Delete(int KategoriId);
        [OperationContract]
        void Update(Category kategori);
    }
}
