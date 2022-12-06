//using ConceptImportantsCore.DependencyInjection.DIP;
using ConceptImportantsCore.DependencyInjection.DIP;
using ConceptImportantsCore.DependencyInjection.Unity;
using ConceptImportantsCore.LambdaExpression;
using ConceptImportantsCore.MethodeExtension;
using System;
using System.Diagnostics;

namespace ConceptImportants
{
    public class Program
    {
       static public void Main(string [] args)
       {
            //ConceptImportantsCore.DependencyInjection.DIP.Container toutlesenario = new Container();
            //toutlesenario.TouteLAffaire();
            //var application = new ConceptImportantsCore.DependencyInjection.Unity.Application();
            //application.ConsommerService(ConceptImportantsCore.ServiceKind.Srv1);

            //List<Personne> personnes1 = new List<Personne>();
            //personnes1.Add(new Personne { Nom = "Personnea", Age = 14 });
            //personnes1.Add(new Personne { Nom = "Personneb", Age = 14 });

            //personnes1.Affiche();

            //Personne[] personnes2 ={new Personne { Nom = "Personnea", Age = 14 },
            //new Personne { Nom = "Personneb", Age = 14 },
            //new Personne { Nom = "Personnec", Age = 14 } };

            //personnes1.Affiche();

            //Dictionnaire<string> mondictionaire = new Dictionnaire<string>(2);
            //mondictionaire.Ajouter(0, new Tuple<int, string>(0, "zero"));
            //mondictionaire.Ajouter(1, new Tuple<int, string>(1, "un"));

            //mondictionaire.Affiche();

           // Ecole eleves = new Ecole();
            //var element = eleves.Rechercher(e => e.Id == 8);

            ResultatCalcul((x, y) => x - y);

        }

        static public double somme(double a,double b)
        {
            return a + b; 
        }


        static void ResultatCalcul(Func<double,double,double> Operation)
        {
            Debug.WriteLine(Operation.Invoke(5,3));
        }

        static  void ResultatCalcul1(double a,double b)
        {
            double resultat = a + b;
            Debug.WriteLine(resultat);
        }
        static void ResultatCalcul2(double a, double b)
        {
            double resultat = a - b;
            Debug.WriteLine(resultat);
        }
        static void ResultatCalcul3(double a, double b)
        {
            double resultat = a * b;
            Debug.WriteLine(resultat);
        }
        static void ResultatCalcul4(double a, double b)
        {
            double resultat = a / b;
            Debug.WriteLine(resultat);
        }
    }
}
