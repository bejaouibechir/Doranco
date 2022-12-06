using ConceptImportantsCore.DependencyInjection.IOC;
using System;

namespace ConceptImportants
{
    public class Program
    {
       static public void Main(string [] args)
       {
            Container toutlesenario = new Container();
            toutlesenario.TouteLAffaire();
       }
    }
}
