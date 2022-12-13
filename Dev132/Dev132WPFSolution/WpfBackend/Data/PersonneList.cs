using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{
    public class PersonneList : List<Personne>
    {
        public PersonneList()
        {
            Add(new Personne {Id=1, Age=22, Nom= "Tamara Solomon", Poid=70, Taille=1.8 });
            Add(new Personne { Id = 2, Age = 22, Nom = "Tamara Solomon", Poid = 70, Taille = 1.8 });
            Add(new Personne { Id = 3, Age = 23, Nom = "Leia Hickman", Poid = 71, Taille = 1.8 });
            Add(new Personne { Id = 4, Age = 31, Nom = "Heath Coffey", Poid = 50, Taille = 1.6 });
            Add(new Personne { Id = 5, Age = 25, Nom = "Eoin Moon", Poid = 70, Taille = 1.8 });
            Add(new Personne { Id = 6, Age = 21, Nom = "Iestyn Roberson", Poid = 70, Taille = 1.8 });
            Add(new Personne { Id = 7, Age = 25, Nom = "Harun Atkinson", Poid = 70, Taille = 1.8 });
            Add(new Personne { Id = 8, Age = 27, Nom = "Georgina Mcgee", Poid = 70, Taille = 1.8 });
            Add(new Personne { Id = 9, Age = 32, Nom = "Bobby Davies", Poid = 70, Taille = 1.8 });
            Add(new Personne { Id = 10, Age = 41, Nom = "Adnan Ward", Poid = 70, Taille = 1.8 });
        }

        public void AddPersonne(Personne p)
        {
            this.Add(p);
        }
        public void DeletePersonne(Personne p)
        {
            this.Remove(p);
        }
        public void UpdatePersonne(int id, Personne newp)
        {
            Personne current = GetPersonne(id);
            if (current != null)
                current = newp;
        }

        public Personne GetPersonne(int id)
        {
            return this.SingleOrDefault(p => p.Id == id);
        }

        public List<Personne> ListPersonne()
        {
            return this;
        }

    }
}


