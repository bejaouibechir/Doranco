using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfWeb
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FootService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FootService.svc or FootService.svc.cs at the Solution Explorer and start debugging.
    public class FootService :ISpecialFootDervice
    {
        //Abonnement basique
        public string Fonction1()
        {
            return "Regarder quelques matchs en redifusion (après 1heure)";
        }

        public string Fonction2()
        {
            return "Voir tout les match en live";
        }

        public string Fonction3()
        {
            return "enregister des matchs ";
        }

        public string Fonction4()
        {
            return "Afficher le calendrier des matchs";
        }
    }
}
