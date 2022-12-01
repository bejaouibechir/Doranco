
using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MVVMCalculator.Helpers
{
    /// <summary>
    /// Commande routée qui représente les interractions du client avec l'interface
    /// </summary>
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        //Des delegates 
        Func<object, bool> _canexecute;
        Action<object> _execute;

        public DelegateCommand(Action<object> execute, Func<object, bool> canexecute)
        {
            _canexecute = canexecute;
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }






    public class SommeCommand : ICommand
    {
        Arithmetique arithmetique = new Arithmetique();
        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            arithmetique.Somme(11, 22);
        }
    }

    public class AfficheCommand : ICommand
    {
        Affiche display = new Affiche();

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            display.Display("Mon message");
        }
    }

    public class RapportCommand : ICommand
    {
        Rapport rp = new Rapport();

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            rp.Generer();
        }
    }



    //Tache 1
    public class Arithmetique
    {
        public double Somme(double a,double b)
        {
            return a + b;
        }
    }

    //Tache 2
    public class Affiche
    {
        public void Display(string message)
        {
            Debug.WriteLine(message);
        }
    }


    //Tache 3
    public class Rapport
    {
        public void Generer()
        {
            Debug.WriteLine("Un rapport est généré");
        }
    }

}
