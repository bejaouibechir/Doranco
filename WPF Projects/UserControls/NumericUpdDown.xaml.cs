using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControls
{
    /// <summary>
    /// Interaction logic for NumricUpDown.xaml
    /// </summary>
    public partial class NumricUpDown : UserControl
    {
        public NumricUpDown()
        {
            InitializeComponent();
        }
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(NumricUpDown), new PropertyMetadata(0));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RepeatButton current = sender as RepeatButton;
            if (current.Name == "ButtonUp")
            {
                Value++;
                TextNumber.Text = Value.ToString();
            }
            else if (current.Name == "ButtonDown")
            {
                Value--;
                TextNumber.Text = Value.ToString();
            }
        }

        private void TextNumber_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {

        }

        private void TextNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
