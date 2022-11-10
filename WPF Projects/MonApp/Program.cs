#define linux_env
//#define windows_env

using System;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;
using MonApp.Model;
using System.IO;

namespace MonApp
{


    class Employée
    {
        public string Nom;
        public string Ecole;

        public override string ToString()
        { return "{Nom} est à l'école {Ecole}"; }
        

    }

    //Le code appelant 
    internal class Program 
    { //Début Portée de classe

        
        static void Main(string[] args)
        {
          
            Console.Read();
        }
 
    }//Fin portée de classe

    
    

}








//public class GrandMère
//{

//    public string Nom { get; set; }
//    public string Prénom { get; set; }

//    //Constrcuteur sans paramètres
//    public GrandMère()
//    {
//        ;
//    }
//    //Contructeur sans paramètres
//    public GrandMère(string nom, string prénom)
//    {
//        Nom = nom;
//        Prénom = prénom;
//    }

//    //Contructeur sans paramètres
//    public GrandMère(string nom) : this()
//    {
//        Nom = nom;
//    }
//}
//public class Mère : GrandMère
//{
//    public Mère() : base("Eve")
//    {
//        ;
//    }
//}
//public class Fille : Mère
//{
//    public Fille()
//    {
//        ;
//    }
//}
