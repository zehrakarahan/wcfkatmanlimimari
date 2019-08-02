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
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();
        [OperationContract]
        Product Get(int ProductId);
        [OperationContract]
        void Add(Product product);
        [OperationContract]
        void Delete(int ProductId);
        [OperationContract]
        void Update(Product product);
    }
}
