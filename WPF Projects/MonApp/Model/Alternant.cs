using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.Model
{
    public class Alternant :Humain
    {
        public decimal TJM { get; set; } //Taux journalier moyen

        
        public void collabore()
        {
            Console.WriteLine($"{Nom} collabore dans le dépratement {LieuTravail}");
        }

        public override void afficherNom()
        {
            Console.WriteLine($"Je suis {Nom} je suis alternant et je collabore dans {LieuTravail} ");
        }


    }
}
