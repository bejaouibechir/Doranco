using System.Collections.Generic;
using System.ServiceModel;

namespace ProducServiceWCF
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        void Add(Product product);

        [OperationContract]
        void Update(int id,Product newproduct);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        Product Get(int id);

        [OperationContract]
        List<Product> List();

    }
}
