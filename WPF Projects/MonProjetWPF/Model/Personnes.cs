using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjetWPF.Model
{
    public class Personnes : List<Personne>
    {
        public Personnes()
        {
            Add(new Personne { Id =1,Name="moi",Age=44 });
            Add(new Personne { Id = 2, Name = "lui", Age = 30 });
            Add(new Personne { Id = 3, Name = "elle", Age = 25 });
        }
    }
}
