using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessageContractProjet
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        [FaultContract(typeof(Exception))]
        public SecretDataResponse GetData(SecretDataRequest request)
        {

            try
            {
                //A tester avec le hash 2005349439 et avec un autre hash 30025698 et observer 
                //le message request (le soap xml) pour voir le header 
                SecretData secret = new SecretData { SecretMessage = "Les données supposée cachée" };
                //si Password = password123  passe sinon en lève une excpetion
                if (request.Hash == 2005349439)
                {
                    return new SecretDataResponse(secret);
                }
                else
                {
                    throw new Exception("Votre mot de passe est invalide reconnectez vous au service avec un " +
                        "mot de passe correct ou contacter votre administrateur");
                }
            }
            catch (FaultException<Exception> erreur)
            {
                Debug.WriteLine(erreur.Detail.Message);
                return null;
            }
        }
    }
}
