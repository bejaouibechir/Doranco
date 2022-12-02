using MVVMCalculator.Helpers;
using System;

namespace MVVMCalculator.Model
{
    public class CalculatorModel
    {

        #region Private members

        string result;

        #endregion

        #region Constructors

        public CalculatorModel(string firstOperand, string secondOperand, string operation)
        {
            ValidateOperand(firstOperand);
            ValidateOperand(secondOperand);
            ValidateOperation(operation);

            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            Operation = operation;
            result = string.Empty;
        }

        public CalculatorModel(string firstOperand, string operation)
        {
            ValidateOperand(firstOperand);
            ValidateOperation(operation);

            FirstOperand = firstOperand;
            SecondOperand = string.Empty;
            Operation = operation;
            result = string.Empty;
        }

        public CalculatorModel()
        {
            FirstOperand = string.Empty;
            SecondOperand = string.Empty;
            Operation = string.Empty;
            result = string.Empty;
        }

        #endregion


        #region Les propriétés

        /// <summary>
        /// C'est la première opérande de l'operation
        /// </summary>
        public string FirstOperand { get; set; }
        /// <summary>
        /// C'est la deuxième opérande de l'operation
        /// </summary>
        public string SecondOperand { get; set; }
        /// <summary>
        /// C'est l'operation qui devrait être soit + - x / cos sin tan
        /// </summary>
        public string Operation { get; set; }
        /// <summary>
        /// C'est le resultat de l'opération de calcul
        /// </summary>
        public string Result
        { 
            get { return result; }
            set { result = value; }
        }

        #endregion


        #region La validation
        private void ValidateOperand(string operand)
        {
            try
            {
                Convert.ToDouble(operand);
            }
            catch (Exception)
            {
                result = "Invalid number: " + operand;
                throw;
            }
        }


        private void ValidateOperation(string operation)
        {
            switch (operation)
            {
                case "/":
                case "*":
                case "-":
                case "+":
                case "tan":
                case "cos":
                case "sin":
                    break;
                default:
                    result = "Unknown operation: " + operation;
                    throw new ArgumentException("Unknown Operation: " + operation, "operation");
            }
        }

        private void ValidateData()
        {
            switch (Operation)
            {
                case "/":
                case "*":
                case "-":
                case "+":
                    ValidateOperand(FirstOperand);
                    ValidateOperand(SecondOperand);
                    break;
                case "tan":
                case "cos":
                case "sin":
                    ValidateOperand(FirstOperand);
                    break;
                default:
                    result = "Unknown operation: " + Operation;
                    throw new ArgumentException("Unknown Operation: " + Operation, "operation");
            }
        }

        #endregion

        public void CalculateResult()
        {
            ValidateData();

            try
            {
                switch (Operation)
                {
                    case ("+"):
                        result = (Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("-"):
                        result = (Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("*"):
                        result = (Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("/"):
                        result = (Convert.ToDouble(FirstOperand) / Convert.ToDouble(SecondOperand)).ToString();
                        break;

                    case ("sin"):
                        result = Math.Sin(Utility.DegreeToRadian(Convert.ToDouble(FirstOperand))).ToString();
                        break;

                    case ("cos"):
                        result = Math.Cos(Utility.DegreeToRadian(Convert.ToDouble(FirstOperand))).ToString();
                        break;

                    case ("tan"):
                        result = Math.Tan(Utility.DegreeToRadian(Convert.ToDouble(FirstOperand))).ToString();
                        break;
                }
            }
            catch (Exception)
            {
                result = "Error whilst calculating";
                throw;
            }
        }

    }
}

