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
using WpfClientAsmx.ProductServiceRef;

namespace WpfClientAsmx
{
    /// <summary>
    /// Interaction logic for GetProductWinodw.xaml
    /// </summary>
    public partial class GetProductWinodw : Window
    {
        
        public GetProductWinodw()
        {
            InitializeComponent();
        }

        public Product CurrentProduct { get; set; }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            CurrentProduct = new Product();
            CurrentProduct.Id = int.Parse(txtId.Text);
            Close();
        }
    }
}
