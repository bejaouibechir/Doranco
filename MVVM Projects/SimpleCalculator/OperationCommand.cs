using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Input;

namespace SimpleCalculator
{
    public class OperationCommand : ICommand
    {
        ViewModel _viewModel;
        public OperationCommand(ViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            OperationKind operationKind;
            int input = (int)parameter;
            switch (input)
            {
                case 0:
                   operationKind = OperationKind.Addition;
                    break;
                case 1:
                    operationKind = OperationKind.Soustraction; 
                    break;
                case 2:
                    operationKind = OperationKind.Multiplication;
                    break;
                case 3:
                    operationKind = OperationKind.Division;
                    break;
                default:
                    throw new ArgumentException("Il faut choisir une opération");
            }
            _viewModel.Operation(operationKind);
        }
    }

}
