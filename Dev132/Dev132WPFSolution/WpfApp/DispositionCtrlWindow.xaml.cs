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
    /// Interaction logic for DispositionCtrlWindow.xaml
    /// </summary>
    public partial class DispositionCtrlWindow : Window
    {
        public DispositionCtrlWindow()
        {
            InitializeComponent();
        }

        private void Zindex_Click(object sender, RoutedEventArgs e)
        {
            MenuItem contextMenuItem = sender as MenuItem;
            if(contextMenuItem.Name=="red")
            {
                redbrd.SetValue(Panel.ZIndexProperty, 3);
                greenbrd.SetValue(Panel.ZIndexProperty, 1);
                bluebrd.SetValue(Panel.ZIndexProperty, 1);
            }
            else if(contextMenuItem.Name == "green")
            {
                redbrd.SetValue(Panel.ZIndexProperty, 1);
                greenbrd.SetValue(Panel.ZIndexProperty, 3);
                bluebrd.SetValue(Panel.ZIndexProperty, 1);
            }
            else if (contextMenuItem.Name == "blue")
            {
                redbrd.SetValue(Panel.ZIndexProperty, 1);
                greenbrd.SetValue(Panel.ZIndexProperty, 1);
                bluebrd.SetValue(Panel.ZIndexProperty, 3);
            }
        }
    }
}
