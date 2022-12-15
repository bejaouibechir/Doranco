using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{
    public class Personne : IComparable<Personne>
    {
        public int Id { get; set; }


        public string Nom { get; set; }

        public double Taille { get; set; }

        public double Poid { get; set; }

        public int Age { get; set; }

        public int CompareTo(Personne other)
        {
            if(Nom.Length> other.Nom.Length)
            {
                return 1;
            }
            else if(Nom.Length< other.Nom.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Id: {Id} Nom:{Nom} Taille:{Taille} Poid:{Poid} Age:{Age} ";
        }

    }
}
