using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfIntra
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ArithmetiqueService" in both code and config file together.
    public class ArithmetiqueService : IArithmetiqueService
    {
        
        public double Division(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException erreur)
            {
                Debug.WriteLine(erreur.Message);
                return 0;
            }
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Somme(double a, double b)
        {
            return a + b;
        }

        public double Soustraction(double a, double b)
        {
            return a - b;
        }
    }
}
