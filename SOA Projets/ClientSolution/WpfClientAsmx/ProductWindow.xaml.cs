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
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }
        public Product Current { get; set; }

        public void Cancel_Click(object sender,RoutedEventArgs args)
        {
            Close();
        }
        public void Confirm_Click(object sender, RoutedEventArgs args)
        {
            Current = new Product();
            Current.Name = txtName.Text;
            Current.Color = txtColor.Text;
            Current.Cost = decimal.Parse(txtCost.Text);
            Current.Price = decimal.Parse(txtPrice.Text);
            Current.CreationDate = DateTime.Parse(ctrlDate.Text);
            Close();
        }
    }

    
}
