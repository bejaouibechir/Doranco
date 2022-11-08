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
    /// Interaction logic for FourthWindow.xaml
    /// </summary>
    public partial class FourthWindow : Window
    {
        public FourthWindow()
        {
            InitializeComponent();

            _initialwidth = monimage.Width;
            _initialheight = monimage.Height;
            _width = monimage.Width;
            _height = monimage.Height;
        }

        double _width;
        double _height;
        double _initialwidth;
        double _initialheight;

        private void Zoom_In(object sender, RoutedEventArgs e)
        {
            _width = _width + 10;
            _height = _height + 10;
            monimage.Width = _width;
            monimage.Height = _height;
        }

        private void Zoom_Out(object sender, RoutedEventArgs e)
        {
            _width = _width - 10;
            _height = _height - 10;
            monimage.Width = _width;
            monimage.Height = _height;
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            monimage.Width = _initialwidth;
            monimage.Height = _initialheight;
        }
    }
}
