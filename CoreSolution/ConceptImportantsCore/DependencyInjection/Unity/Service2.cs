using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptImportantsCore.DependencyInjection.Unity
{
    public class Service2 : IService
    {
        public void fonctionalité()
        {
            Debug.WriteLine("Fonctionalité qui fait partie de service 2");
        }
    }
}
