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
    /// Interaction logic for ChessWindow.xaml
    /// </summary>
    public partial class ChessWindow : Window
    {

        #region pieces blanches
        Ellipse epsb1;
        Ellipse epsb2;
        Ellipse epsb3;
        Ellipse epsb4;
        Ellipse epsb5;
        Ellipse epsb6;
        Ellipse epsb7;
        Ellipse epsb8;
        Ellipse epsb9;
        Ellipse epsb10;
        Ellipse epsb11;
        Ellipse epsb12;
        Ellipse epsb13;
        Ellipse epsb14;
        Ellipse epsb15;
        Ellipse epsb16;

        #endregion

        #region pieces blanches
        Ellipse epsn1;
        Ellipse epsn2;
        Ellipse epsn3;
        Ellipse epsn4;
        Ellipse epsn5;
        Ellipse epsn6;
        Ellipse epsn7;
        Ellipse epsn8;
        Ellipse epsn9;
        Ellipse epsn10;
        Ellipse epsn11;
        Ellipse epsn12;
        Ellipse epsn13;
        Ellipse epsn14;
        Ellipse epsn15;
        Ellipse epsn16;

        #endregion

        public ChessWindow()
        {
            InitializeComponent();
            initializePiecesDames();
        }

        public void initializePiecesDames()
        {
            epsb1 = new Ellipse();
            epsb1.Width = 60;
            epsb1.Height = 60;
            epsb1.Fill = new SolidColorBrush(Colors.White);
            scenegrd.Children.Add(epsb1);
            epsb1.SetValue(Grid.ColumnProperty, 0);
            epsb1.SetValue(Grid.RowProperty, 0);

            epsb2 = new Ellipse();
            epsb2.Width = 60;
            epsb2.Height = 60;
            epsb2.Fill = new SolidColorBrush(Colors.White);
            scenegrd.Children.Add(epsb2);
            epsb2.SetValue(Grid.ColumnProperty, 1);
            epsb2.SetValue(Grid.RowProperty, 0);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
