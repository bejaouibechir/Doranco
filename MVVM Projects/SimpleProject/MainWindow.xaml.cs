using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IModel _context;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionMode = ConfigurationManager.AppSettings["choix"].ToString();
            Choix choix;
            if (connectionMode == "EF")
            { 
                choix = Choix.EF; 
            }
            else
            {
                choix = Choix.Liste;
            }

            switch (choix)
            {
                case Choix.EF:
                    _context = new AdventureWorksLT2014Entities();
                    dgdata.ItemsSource = _context.Products.ToList();
                    break;
                case Choix.Liste:
                    _context = new ProductList();
                    dgdata.ItemsSource = (List<Product>)_context;
                    break;
                default:
                    _context = new ProductList();
                    dgdata.ItemsSource = (List<Product>)_context;
                    break;
            }
        } 
    }

    public enum Choix
    {
        EF, Liste
    }
}
