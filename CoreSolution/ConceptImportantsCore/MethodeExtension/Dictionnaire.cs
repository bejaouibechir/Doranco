using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptImportantsCore.MethodeExtension
{
    public class Dictionnaire<T> :IEnumerable
    {
        Tuple<int, T>[] _conteneur; 
        public Dictionnaire(int dimension)
        {
            _conteneur = new Tuple<int, T>[dimension];
        }

        public void Ajouter(int i,Tuple<int, T> element)
        {
            _conteneur[i] = element;
        }

        public IEnumerator GetEnumerator()
        {
            return _conteneur.GetEnumerator();
        }
    }
}
