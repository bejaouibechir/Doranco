using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfWeb
{
    [ServiceContract]
    public interface ISpecialFootDervice : IFootService
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
