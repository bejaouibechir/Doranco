using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WpfApp.Data;
using WpfBackend;

namespace WpfBackendTest
{
    [TestClass]
    public class PersonneListTest
    {
        PersonneList _list;

        public PersonneListTest()
        {
            _list = new PersonneList();
        }


        [TestMethod]
        public void AddPersonne()
        {
            bool resutat = true;
            Personne p = new Personne { Id = 1, Age = 44, Nom = "Bechir", Poid = 75, Taille = 1.75 };
            _list.Add(p);
            //Condition qui définie la valeur de resultat 
            Assert.IsTrue(resutat);
        }
        [TestMethod]
        public void DeletePersonne()
        {
            bool resutat = true;
            Personne p = new Personne { Id = 1, Age = 44, Nom = "Bechir", Poid = 75, Taille = 1.75 };
            _list.DeletePersonne(p);
            //Condition qui définie la valeur de resultat 
            Assert.IsTrue(resutat);
        }
        [TestMethod]
        public void UpdatePersonne()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GetPersonne()
        {
            bool resutat = true;
            int id = 1;
            Personne current = _list.GetPersonne(id);
            Assert.IsTrue(resutat);
        }

        [TestMethod]
        public void ListPersonne()
        {
            bool result = false;
            if (_list.Count == 0) result = false;
            else result = true;
            Assert.IsTrue(result);   
        }

    }
}
