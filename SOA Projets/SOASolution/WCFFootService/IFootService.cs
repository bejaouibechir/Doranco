using System.ServiceModel;
namespace WCFFootService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFootService" in both code and config file together.
    [ServiceContract]
    public interface IFootService
    {
        [OperationContract]
        string Fonction1();
    }

   
}
