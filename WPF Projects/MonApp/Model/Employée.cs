using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.Model
{
  

    public class Employée :Humain
    {

        

        public Employée Superieur  { get; set; }

        public void Travaille()
        {
            Console.WriteLine($"{Nom} travaille dans {LieuTravail}");
        }

        public Salaire SalaireEmployee { get; set; }

        public Promotion PromotionEmployee { get; set; }

        public override void afficherNom()
        {
            Console.WriteLine($"Je suis {Nom} je suis employée et je collabore dans {LieuTravail} ");
        }

    }
}
