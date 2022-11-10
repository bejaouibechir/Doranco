using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjetWPF.Model
{
    public class Employee :Personne
    {
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Age:{Age} Salary:{Salary} ";
        }

    }
}
