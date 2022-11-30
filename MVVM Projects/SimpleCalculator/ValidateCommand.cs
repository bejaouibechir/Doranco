using System;
using System.Windows;
using System.Windows.Input;

namespace SimpleCalculator
{
    public class ValidateCommand : ICommand
    {

        ViewModel _vmodel;
        public ValidateCommand(ViewModel vmodel)
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
            _vmodel.ValidateEntries();
        }
    }
}
