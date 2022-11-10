using System;
using System.Collections.Generic;

namespace MonProjetWPF.Model
{
    public class Personne 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Age:{Age}";
        }

    }
}
