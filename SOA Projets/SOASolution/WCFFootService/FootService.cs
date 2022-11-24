using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFFootService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FootService" in both code and config file together.
    public class FootService :ISpecialFootService
    {
        #region classique
        public string Fonction1()
        {
            return "Regarder quelques matchs en redifusion (après 1heure)";
        }
        #endregion

        #region vip
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
        #endregion

    }
}
