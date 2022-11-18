//#define modedynamique
#define modedesign

using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfAppDeconnecté
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



        string connstring = "Data Source=PC2022;Initial Catalog=AdventureWorksLT2014;Integrated Security=True";
        SqlConnection _connection;//Usine
        SqlCommand _command; //Commande
        SqlDataAdapter _adapter; //Camion
#if modedynamique
        DataSet _dsAventureWorks;//Dépôt 
        DataTable _dtProduitsTop20;
#endif
#if modedesign
        AdventureWorksDS _dsAventureWorks;
#endif
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _connection = new SqlConnection(connstring);
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM [SalesLT].[Customer]", _connection);
            _adapter = new SqlDataAdapter(_command);

#if modedynamique
            _dtProduitsTop20 = new DataTable();
            _adapter.Fill(_dtProduitsTop20);
            gridProduit.ItemsSource = _dtProduitsTop20.AsDataView();
            //Du code ......
            _adapter.Update(_dtProduitsTop20);
#endif
#if modedesign
            _dsAventureWorks = new AdventureWorksDS();//Représentation de la base aventureworkslt2014 en format XML à un instant t
            AdventureWorksDSTableAdapters.CustomerTableAdapter customertableAdapter 
                = new AdventureWorksDSTableAdapters.CustomerTableAdapter();
            AdventureWorksDS.CustomerDataTable customerDataTable
                = new AdventureWorksDS.CustomerDataTable();
            customertableAdapter.Remplir(customerDataTable);
            gridProduit.ItemsSource = customerDataTable.AsDataView();
#endif


        }
    }
}
