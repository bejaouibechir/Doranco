using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApp.Model
{
    public class Stagiaire :Humain
    {

        public Stagiaire()
        {
            
        }

        public DateTime DébutStage { get; set; }

        public DateTime FinStage { get; set; }

        public void apprend()
        {
            Console.WriteLine($"{Nom} apprend la façon de travailler dans le département {LieuTravail}");
        }
        public override void afficherNom()
        {
            Console.WriteLine($"Je suis {Nom} je suis stagiaire et j'apprend à travailler dans {LieuTravail} ");
        }
    }
}
