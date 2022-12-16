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

namespace WpfUserControlsLibrary
{
    /// <summary>
    /// Interaction logic for NumericUpDownControl.xaml
    /// </summary>
    public partial class NumericUpDownControl : UserControl
    {
        public NumericUpDownControl()
        {
            InitializeComponent();
        }

        /*Il ne faut pas utiliser des propriétés (CLR) comme propriétés pour un contrôle au cas où
          ces propriétés vont être utilisées dans le XAML 
         */
        //public int Value { get; set; } //Une propriété CLR



        /*
         Les propriétés définie au niveau du contrôle qui sont sensées d'être utilisées dans le XAML 
         devront être de type propriété de dépendance 
         
         */
        //public int Value
        //{
        //    get { return (int)GetValue(ValueProperty); }
        //    set { SetValue(ValueProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for ValueProperty.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ValueProperty =
        //    DependencyProperty.Register("Value", typeof(int), typeof(NumericUpDownControl), new PropertyMetadata(0));




        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(NumericUpDownControl), new PropertyMetadata(0));







        public int Seuil
        {
            get { return (int)GetValue(SeuilProperty); }
            set { SetValue(SeuilProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Seuil.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SeuilProperty =
            DependencyProperty.Register("Seuil", typeof(int), typeof(NumericUpDownControl), new PropertyMetadata(100));








        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RepeatButton button = sender as RepeatButton;
            if (button.Name == "ButtonUp")
            {
                Value++;
                TextNumber.Text = ValueProperty.ToString();
            }
            else if(button.Name == "ButtonDown")
            {
                Value--;
                TextNumber.Text = ValueProperty.ToString();
            }
        }




       
    }
}
