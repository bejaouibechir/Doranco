using System;
using System.Windows.Input;

namespace ERPProject.Helpers
{
    public class DelegateCommand<T> : ICommand
    {

        Func<object, bool> _canexecute;
        Action<object> _execute;
        public DelegateCommand(Func<object, bool> canexecute, Action<object> execute)
        {
            _canexecute = canexecute;
            _execute = execute;
        }
        
        
        public event EventHandler CanExecuteChanged
        { 
           add { CommandManager.RequerySuggested += value; }
           remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return _canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public bool CanExecute(T parameter)
        {
            return _canexecute(parameter);
        }

        public void Execute(T parameter)
        {
            _execute(parameter);
        }

    }
}
