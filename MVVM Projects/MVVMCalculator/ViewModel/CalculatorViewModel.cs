using MVVMCalculator.Helpers;
using MVVMCalculator.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMCalculator.ViewModel
{
    public class CalculatorViewModel : ViewModelBase
    {
        #region champs privée
        private CalculatorModel calculation;
        private string lastOperation;
        private bool newDisplayRequired = false;
        private string fullExpression;
        private string display;


        #endregion


        #region Constructeur

        public CalculatorViewModel()
        {
            calculation = new CalculatorModel();
            display = "0";
            FirstOperand = string.Empty;
            SecondOperand = string.Empty;
            Operation = string.Empty;
            lastOperation = string.Empty;
            fullExpression = string.Empty;
        }

        #endregion


        #region Les commandes

        private DelegateCommand _digitButtonPressCommand;
        private DelegateCommand _operationButtonPressCommand;
        private DelegateCommand _singular_operationButtonPressCommand;

        public DelegateCommand DigitButtonPressCommand
        {
            get
            {
                if (_digitButtonPressCommand == null)
                {
                    _digitButtonPressCommand = new DelegateCommand(
                        DigitButtonPress,CanDigitButtonPress);
                }
                return _digitButtonPressCommand;
            }

            set
            {
                _digitButtonPressCommand = value;
            }
        }

        private void DigitButtonPress(object arg)
        {
            string content = (string)arg;
            switch (content)
            {
                case "C":
                    Display = "0";
                    FirstOperand = string.Empty;
                    SecondOperand = string.Empty;
                    Operation = string.Empty;
                    LastOperation = string.Empty;
                    FullExpression = string.Empty;
                    break;
                case "Del":
                    if (display.Length > 1)
                        Display = display.Substring(0, display.Length - 1);
                    else Display = "0";
                    break;
                case "+/-":
                    if (display.Contains("-") || display == "0")
                    {
                        Display = display.Remove(display.IndexOf("-"), 1);
                    }
                    else Display = "-" + display;
                    break;
                case ".":
                    if (newDisplayRequired)
                    {
                        Display = "0.";
                    }
                    else
                    {
                        if (!display.Contains("."))
                        {
                            Display = display + ".";
                        }
                    }
                    break;
                default:
                    if (display == "0" || newDisplayRequired)
                        Display = content;
                    else
                        Display = display + content;
                    break;
            }
            newDisplayRequired = false;

        }

        private bool CanDigitButtonPress(object arg)
        {
            return true;
        }


        public DelegateCommand OperationButtonPressCommand
        {
            get
            {
                if (_operationButtonPressCommand == null)
                {
                    _operationButtonPressCommand = new DelegateCommand(
                        OperationButtonPress, CanOperationButtonPress);
                }
                return _operationButtonPressCommand;
            }
            set { _operationButtonPressCommand = value; }

        }
        private bool CanOperationButtonPress(object arg)
        {
            return true;
        }
        private void OperationButtonPress(object obj)
        {
            string operation = (string)obj; // "+" "-" "x" "/" ou "="
            
            try
            {
                if (FirstOperand == string.Empty || LastOperation == "=")
                {
                    FirstOperand = display;
                    LastOperation = operation;
                }
                else
                {
                    SecondOperand = display;
                    Operation = lastOperation;
                    calculation.CalculateResult();

                    FullExpression = Math.Round(Convert.ToDouble(FirstOperand), 10) + " " + Operation + " "
                                    + Math.Round(Convert.ToDouble(SecondOperand), 10) + " = "
                                    + Math.Round(Convert.ToDouble(Result), 10);

                    LastOperation = operation;
                    Display = Result;
                    FirstOperand = display;
                }
                newDisplayRequired = true;
            }
            catch (Exception ex)
            {
                Display = Result == string.Empty ? "Error - see event log" : Result;
                LogExceptionInformation(ex);
            }

        }

       

        public DelegateCommand Singular_operationButtonPressCommand
        {
            get
            {
                if (_singular_operationButtonPressCommand == null)
                {
                    _singular_operationButtonPressCommand = new DelegateCommand(
                         SingularOperationButtonPress, CanSingularOperationButtonPress);
                }
                return _singular_operationButtonPressCommand;
            }

            set
            {
                _singular_operationButtonPressCommand = value;
            }
        }

        private void SingularOperationButtonPress(object obj)
        {
            string operation = (string)obj;
            try
            {
                FirstOperand = Display;
                Operation = operation;
                calculation.CalculateResult();

                FullExpression = Operation + "(" + Math.Round(Convert.ToDouble(FirstOperand), 10) + ") = "
                    + Math.Round(Convert.ToDouble(Result), 10);

                LastOperation = "=";
                Display = Result;
                FirstOperand = display;
                newDisplayRequired = true;
            }
            catch (Exception ex)
            {
                Display = Result == string.Empty ? "Error - see event log" : Result;
                //LogExceptionInformation(ex);
            }

        }
        private bool CanSingularOperationButtonPress(object arg)
        {
            return true;
        }


        #endregion


        #region Propriétés publiques

        public string FirstOperand
        {
            get { return calculation.FirstOperand; }
            set { calculation.FirstOperand = value; }
        }

        public string SecondOperand
        {
            get { return calculation.SecondOperand; }
            set { calculation.SecondOperand = value; }
        }

        public string Operation
        {
            get { return calculation.Operation; }
            set { calculation.Operation = value; }
        }

        public string LastOperation
        {
            get { return lastOperation; }
            set { lastOperation = value; }
        }

        public string Result
        {
            get { return calculation.Result; }
        }

        public string Display
        {
            get { return display; }
            set
            {
                display = value;
                OnPropertyChanged("Display");
            }
        }

        public string FullExpression
        {
            get { return fullExpression; }
            set
            {
                fullExpression = value;
                OnPropertyChanged("FullExpression");
            }
        }
        #endregion



        private void LogExceptionInformation(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

    }
}
