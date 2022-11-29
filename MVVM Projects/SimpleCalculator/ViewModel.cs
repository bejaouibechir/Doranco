using System.Windows;

namespace SimpleCalculator
{
    public class ViewModel

    {
        public Model CalculatorModel { get; set; } = new Model();

        public CalculateCommand CalculateCmd { get; set; }

        public ViewModel()
        {
            CalculateCmd = new CalculateCommand(this);
        }

        public void calculate()
        {
           CalculatorModel.Resultat = CalculatorModel.Opérande1 + CalculatorModel.Opérande2;
           MessageBox.Show(CalculatorModel.Resultat.ToString());
        }
    }
}
