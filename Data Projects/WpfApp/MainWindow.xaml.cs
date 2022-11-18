using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string chaineconnection = "Data Source=PC2022;Initial Catalog=AdventureWorksLT2014;Integrated Security=True";
        SqlConnection connection;

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection = new SqlConnection(chaineconnection);
            SqlCommand command = new SqlCommand("SELECT TOP(20) [ProductID],[Name],[Color]," +
                "[ListPrice],[Weight] FROM [SalesLT].[Product]", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Produit> listeproduit = new List<Produit>();
            
            Produit produit;
            //code pour peupler la liste produits
            while (reader.Read())
            {
                produit = new Produit();
                produit.Id = int.Parse(reader[0].ToString());
                produit.Name = reader[1].ToString();
                produit.Color = reader[2].ToString();
                produit.ListPrice = decimal.Parse(reader[3].ToString());
                decimal weightValue;
                decimal.TryParse(reader[4].ToString(),out weightValue);
                produit.Weight = weightValue;
                listeproduit.Add(produit);
            }
            gridProduit.ItemsSource = listeproduit;
        }
    }
    public class Produit { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        public decimal Weight { get; set; }
    }

}
