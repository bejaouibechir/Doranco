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
using WpfApp.Data;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for XamlSamples.xaml
    /// </summary>
    public partial class XamlSamples : Window
    {
        public XamlSamples()
        {
            InitializeComponent();
        }
        Button button;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            //button = new Button();
            //button.Content = "Cliquez moi";
            //button.Background = new SolidColorBrush(Colors.Red);
            //button.Foreground = new SolidColorBrush(Colors.White);
            //container.Children.Add(button);
            //button.Width = 250;
            //button.Height = 100;
            //button.Margin = new Thickness(15, 44, 585, 340);

            //list.ItemsSource = (PersonneList)Resources["plist"];
            


        }
    }
}
