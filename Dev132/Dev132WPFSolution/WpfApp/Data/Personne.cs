using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{

    public enum CompareKind
    {
        Identifiant, Nom, Taille, Poid,Age
    }
    public class Personne : INotifyPropertyChanged
    {
        private int id;
        private string nom;
        private double taille;
        private double poid;
        private int age;
        public Personne()
        {

        }
        public int Id {
            get { return id; }
            set 
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Nom 
        {
            get { return nom; }
            set
            {
                nom = value;
                OnPropertyChanged("Nom");
            }
        }

        public double Taille
        {
            get { return taille; }
            set
            {
                taille = value;
                OnPropertyChanged("Taille");
            }
        }

        public double Poid 
        {
            get { return poid; }
            set
            {
                poid = value;
                OnPropertyChanged("Poid");
            }
        }

        public int Age 
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyname)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public override string ToString()
        {
            return $"Id: {Id} Nom:{Nom} Taille:{Taille} Poid:{Poid} Age:{Age} ";
        }

    }
}
