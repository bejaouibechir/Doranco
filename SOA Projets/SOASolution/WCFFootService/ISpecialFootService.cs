using System.ServiceModel;

namespace WCFFootService
{
    [ServiceContract]
    public interface ISpecialFootService :IFootService
    {
        //Permet de voir tout les match en live
        [OperationContract]
        string Fonction2();

        //Permet d'enregister des matchs 
        [OperationContract]
        string Fonction3();

        //Permet d'afficher le calendrier des matchs
        [OperationContract]
        string Fonction4();
    }
}
