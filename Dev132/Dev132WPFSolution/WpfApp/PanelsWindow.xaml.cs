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
    /// Interaction logic for PanelsWindow.xaml
    /// </summary>
    public partial class PanelsWindow : Window
    {
        public PanelsWindow()
        {
            InitializeComponent();
        }

        double offset = 10.0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            offset += 5;
            elipse.SetValue(Canvas.LeftProperty, offset);
        }

        Visibility visibility;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (visibility == Visibility.Visible) visibility = Visibility.Collapsed;
            else if (visibility == Visibility.Collapsed) visibility = Visibility.Visible;
            leftzone.Visibility = visibility;
        }
    }
}
