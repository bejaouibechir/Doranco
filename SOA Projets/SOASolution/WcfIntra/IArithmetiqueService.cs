using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfIntra
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IArithmetiqueService" in both code and config file together.
    [ServiceContract] //C'est un contrat de service WCF
    public interface IArithmetiqueService
    {
        [OperationContract]
        double Somme(double a, double b);
        [OperationContract]
        double Soustraction(double a, double b);
        [OperationContract]
        double Multiplication(double a, double b);
        [OperationContract]
        double Division(double a, double b);
    }

  
}
