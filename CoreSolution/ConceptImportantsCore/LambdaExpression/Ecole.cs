using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptImportantsCore.LambdaExpression
{
    //public delegate bool Predicate(Eleve eleve);
    public class Ecole :List<Eleve>
    {
        // public bool Rechercher(Predicate  predicate)
        public bool Rechercher(Func<Eleve, bool>  predicate)
        {
            Ecole current = this;
            foreach (var item in current)
            {
                if(predicate.Invoke(item)==true)
                {
                    return true;
                }
            }
            return false;
        }
        
        public Ecole()
        {
            Add(new Eleve { Id = 1, Nom = "Eleve1", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 2, Nom = "Eleve2", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 3, Nom = "Eleve3", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 4, Nom = "Eleve4", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 5, Nom = "Eleve5", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 6, Nom = "Eleve6", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 7, Nom = "Eleve7", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 8, Nom = "Eleve8", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 9, Nom = "Eleve9", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 10, Nom = "Eleve10", Age = 12, Classe = Classe.ClasseA });
            Add(new Eleve { Id = 11, Nom = "Eleve11", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 12, Nom = "Eleve12", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 13, Nom = "Eleve13", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 14, Nom = "Eleve14", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 15, Nom = "Eleve15", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 16, Nom = "Eleve16", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 17, Nom = "Eleve17", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 18, Nom = "Eleve18", Age = 16, Classe = Classe.ClasseB });
            Add(new Eleve { Id = 19, Nom = "Eleve19", Age = 16, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 20, Nom = "Eleve20", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 21, Nom = "Eleve21", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 22, Nom = "Eleve22", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 23, Nom = "Eleve23", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 24, Nom = "Eleve24", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 25, Nom = "Eleve25", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 26, Nom = "Eleve26", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 27, Nom = "Eleve27", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 28, Nom = "Eleve28", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 29, Nom = "Eleve29", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 30, Nom = "Eleve30", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 31, Nom = "Eleve31", Age = 12, Classe = Classe.ClasseC });
            Add(new Eleve { Id = 32, Nom = "Eleve32", Age = 12, Classe = Classe.ClasseC });
        }



       

    }

    public class Eleve
    {
        public int Id { get; set; }

        public string Nom { get; set; }
        public int Age { get; set; }
        public Classe Classe { get; set; }
    }

    public enum Classe
    {
        ClasseA,ClasseB,ClasseC
    }

}
