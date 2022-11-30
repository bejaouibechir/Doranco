using System;
using System.Diagnostics;
using System.Windows;

namespace SimpleCalculator
{
    public class ViewModel
    {
        public Model CalculatorModel { get; set; }

        public OperationCommand SommeCmd { get; set; }

        public ValidateCommand ValidateCmd { get; set; }

        public ViewModel()
        {
            CalculatorModel = new Model();
            SommeCmd = new OperationCommand(this);
            ValidateCmd = new ValidateCommand(this);
        }


        public void Operation(OperationKind operationKind)
        {
            try
            {
                switch (operationKind)
                {
                    case OperationKind.Addition:
                        CalculatorModel.Resultat = CalculatorModel.Operande1 + CalculatorModel.Operande2;
                        MessageBox.Show($"Le resultat est {CalculatorModel.Resultat}");
                        break;
                    case OperationKind.Soustraction:
                        CalculatorModel.Resultat = CalculatorModel.Operande1 - CalculatorModel.Operande2;
                        MessageBox.Show($"Le resultat est {CalculatorModel.Resultat}");
                        break;
                    case OperationKind.Multiplication:
                        CalculatorModel.Resultat = CalculatorModel.Operande1 * CalculatorModel.Operande2;
                        MessageBox.Show($"Le resultat est {CalculatorModel.Resultat}");
                        break;
                    case OperationKind.Division:
                        CalculatorModel.Resultat = CalculatorModel.Operande1 / CalculatorModel.Operande2;
                        MessageBox.Show($"Le resultat est {CalculatorModel.Resultat}");
                        break;
                    default:
                        throw new ArgumentException("Il faut choisir une operation");
                }
            }
            catch (ArgumentException erreur)
            {
                Debug.WriteLine(erreur.Message);
            }

           
        }

        public void ValidateEntries()
        {
            double x, y;
            bool testOperand1 = double.TryParse(CalculatorModel.Operande1.ToString(), out x);
            bool testOperand2 = double.TryParse(CalculatorModel.Operande2.ToString(), out y);

            if (testOperand1 == false)
            {
                MessageBox.Show("Il faut entrer une valeur numérique au niveau du premier champs");
                CalculatorModel.Operande1 = 0;
            }
            if (testOperand2 == false)
            {
                MessageBox.Show("Il faut entrer une valeur numérique au niveau du deuxième champs");
                CalculatorModel.Operande2 = 0;
            }
        }


    }
}
