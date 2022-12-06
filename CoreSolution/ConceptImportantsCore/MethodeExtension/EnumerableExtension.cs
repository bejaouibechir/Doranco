using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptImportantsCore.MethodeExtension
{
    static public class EnumerableExtension
    {
        static public void Affiche(this IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Debug.WriteLine(item.ToString());
            }
        }
    }
}
