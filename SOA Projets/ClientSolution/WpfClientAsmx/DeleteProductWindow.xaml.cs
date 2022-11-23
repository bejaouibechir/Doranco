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
    /// Interaction logic for DeleteProductWindow.xaml
    /// </summary>
   
    public partial class DeleteProductWindow : Window
    {
        public DeleteProductWindow()
        {
            InitializeComponent();
            CurrentProduct = new Product();
        }

        public Product CurrentProduct { get; set; }

        public void btnCancel_Click(object sender, RoutedEventArgs args)
        {
            Close();
        }
        public void btnSearch_Click(object sender, RoutedEventArgs args)
        {
            
            CurrentProduct.Id = int.Parse(txtId.Text);
            Close();
        }

    }
}
