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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfClientAsmx.ProductServiceRef;

namespace WpfClientAsmx
{



    public partial class MainWindow : Window
    {
        //Proxy qui représente le service
        ProductServiceRef.ProductServiceSoapClient _client;
        ProductWindow _formulaire;
        GetProductWinodw _getformulaire;
        DeleteProductWindow _deleteformulaire;
        UpdateProductWindow _updateformulaire;
        Product _product;
        public MainWindow()
        {
            InitializeComponent();
            _client = new ProductServiceRef.ProductServiceSoapClient();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
        private void List_Click(object sender, RoutedEventArgs e)
        {
            productgrid.ItemsSource = _client.List();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _formulaire = new ProductWindow();
            _formulaire.Closing += _formulaire_Closing;
            _formulaire.Show();
        }

        private void _formulaire_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _product = _formulaire.Current;
            _client.Add(_product);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            _updateformulaire = new UpdateProductWindow();
            _updateformulaire.Closing += _updateformulaire_Closing;
            _updateformulaire.Show();
        }

        private void _updateformulaire_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _product = _updateformulaire.Current;
            _client.Update(_updateformulaire.Current.Id, _product);
            MessageBox.Show($"Le produit don't le id est {_product.Id} est mis à jour ", "Mise à jour de produit");
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            _getformulaire = new GetProductWinodw();
            _getformulaire.Closing += _getformulaire_Closing;
            _getformulaire.Show();
        }

        private void _getformulaire_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _product = _getformulaire.CurrentProduct;
            //Lancement de recherche vers le service 
            Product result = _client.Get(_product.Id);
            List<Product> products = new List<Product>();
            products.Add(result);
            productgrid.ItemsSource = products;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            _deleteformulaire = new DeleteProductWindow();
            _deleteformulaire.Closing += _deleteformulaire_Closing;
            _deleteformulaire.Show();
        }

        private void _deleteformulaire_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _product = _deleteformulaire.CurrentProduct;
            _client.Delete(_product.Id);
            MessageBox.Show($"Le produit avec id {_product.Id} est supprimé de la base", 
                "Suppression de produit");
        }
    }
}
