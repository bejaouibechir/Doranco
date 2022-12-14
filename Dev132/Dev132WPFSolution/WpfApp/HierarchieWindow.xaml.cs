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
using System.Windows.Threading;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for HierarchieWindow.xaml
    /// </summary>
    public partial class HierarchieWindow : Window
    {
        public HierarchieWindow()
        {
            InitializeComponent();
        }



        private static T FindAnchestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
                //current = LogicalTreeHelper.GetParent(current)
            }
            while (current != null);
            return null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           //DispatcherObject 
            
            Button clickedBtn = sender as Button;
            var parent = FindAnchestor<Grid>(clickedBtn);
        }
    }
}
