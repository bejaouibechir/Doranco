using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{
    public class Personne
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public double Taille { get; set; }

        public double Poid { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Nom:{Nom} Taille:{Taille} Poid:{Poid} Age:{Age} ";
        }

    }
}
