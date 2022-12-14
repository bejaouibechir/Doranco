using System;
using System.Collections.Generic;
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
    /// Interaction logic for DecoratorsWindows.xaml
    /// </summary>
    public partial class DecoratorsWindows : Window
    {
        public DecoratorsWindows()
        {
            InitializeComponent();
        }

        private void New_MenuItem(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Créer un nouveau fichier");
        }

        private void Open_MenuItem(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ouvrir un  fichier");
        }

        private void Close_MenuItem(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

      
    }
}
