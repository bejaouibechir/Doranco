using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for AbonnementEvent.xaml
    /// </summary>
    public partial class AbonnementEvent : Window
    {

        int choix;
        public AbonnementEvent()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le gestionnaire d'évenements 1");
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le gestionnaire d'évenements 2");
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le gestionnaire d'évenements 3");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                choix = int.Parse(ConfigurationManager.AppSettings["choix"].ToString());
                switch (choix)
                {
                    case 1:
                        btn.Click += Button1_Click;
                        break;
                    case 2:
                        btn.Click += Button2_Click;
                        break;
                    case 3:
                        btn.Click += Button3_Click;
                        break;
                    default:
                        throw new ArgumentException("Vous devez choisir 1, 2 ou 3, prière de revoir le fichier app.config" +
                            "qui accompagne l'excutable d'application pour amples informations");
                }

            }
            catch (ArgumentException erreur)
            {
                Debug.WriteLine(erreur.Message); 
            }
        }

       
    }
}
