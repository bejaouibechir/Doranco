using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.Model
{
    abstract public class Humain
    {
        //Le constructeur
        public Humain()
        {
            ;
        }
        
        public string Nom { get; set; }

        public Departement LieuTravail { get; set; }

       //Une méthode abstraite
        abstract public void afficherNom();
        
    }
}
