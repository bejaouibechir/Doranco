namespace MVCCore.Models
{
    public class Model :List<Personne>
    {
        public Model()
        {
            Add(new Personne { Nom = "PersonneA", Prénom = "PersonneA", Age = 22 });
            Add(new Personne { Nom = "PersonneB", Prénom = "PersonneB", Age = 22 });
            Add(new Personne { Nom = "PersonneC", Prénom = "PersonneC", Age = 22 });
    
        }
    }

    public class  Personne
    {
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Nom: {Nom}, Prénom:{Prénom} et Age: {Age}";
        }
    }
}
