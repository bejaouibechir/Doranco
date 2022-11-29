using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleCalculator
{
    public class CalculateCommand : ICommand
    {
        ViewModel _vmodel;
        public CalculateCommand(ViewModel vmodel)
        {
            _vmodel = vmodel;
        }
        
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vmodel.calculate();
        }
    }
}
