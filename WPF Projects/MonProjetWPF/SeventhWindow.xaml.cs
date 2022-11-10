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
using System.Windows.Shapes;

namespace MonProjetWPF
{
    /// <summary>
    /// Interaction logic for SeventhWindow.xaml
    /// </summary>
    public partial class SeventhWindow : Window
    {
        public SeventhWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string connstring = "Data Source=PC2022;Initial Catalog=AdventureWorks2016;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand command = new SqlCommand("select top(30) * from person.person", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            grid.ItemsSource = table.AsDataView();


        }
    }
}
