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

namespace MonProjetWPF
{
    /// <summary>
    /// Interaction logic for TenthWindow.xaml
    /// </summary>
    public partial class TenthWindow : Window
    {
        public TenthWindow()
        {
            InitializeComponent();
        }

        double _angle = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _angle = _angle + 10;
            line.RenderTransform = new RotateTransform(_angle);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _angle = _angle - 10;
            line.RenderTransform = new RotateTransform(_angle);
        }
    }
}
