using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptImportantsCore.MethodeExtension
{
    public class Personne
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Nom: {Nom} et Age: {Age}";
        }
    }
}
