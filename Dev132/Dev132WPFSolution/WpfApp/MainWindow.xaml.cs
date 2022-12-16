using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AnnulerBtn_Click(object sender, RoutedEventArgs e)
        { 
            //Application.Exit();
            App.Current.Shutdown();           
        }

        

        private void AfficherBtn_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtNom.Text + "\t" + txtPrenom.Text;
            MessageBox.Show(nom, "La boîte de dialogue d'affichage de nom");
            File.WriteAllText(@"C:\temp\mon nom.txt", nom);
        }

        Button currentBtn;
        private void AnnulerBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            //Unboxing
            //Button currentBtn = (Button)sender; //Lève une exception si l'opération de conversion echoue
            currentBtn = sender as Button; //Il y a pas d'excption mais currentBtn = null
            if (currentBtn.Name == "AnnulerBtn")
                AnnulerBtn.Background = new SolidColorBrush(Colors.Red);
            else if (currentBtn.Name == "AfficherBtn")
                AfficherBtn.Background = new SolidColorBrush(Colors.Red);
        }

        private void AnnulerBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            //Unboxing
            //Button currentBtn = (Button)sender; //Lève une exception si l'opération de conversion echoue
            currentBtn = sender as Button; //Il y a pas d'excption mais currentBtn = null
            if (currentBtn.Name == "AnnulerBtn")
                AnnulerBtn.Background = new SolidColorBrush(Colors.Blue);
            else if (currentBtn.Name == "AfficherBtn")
                AfficherBtn.Background = new SolidColorBrush(Colors.Blue);
        }

        TextBox currentTextBox;
        private void txtMouseEnter(object sender, RoutedEventArgs args)
        {
            currentTextBox = sender as TextBox;
            if(currentTextBox.Name== "txtNom")
                txtNom.Background = new SolidColorBrush(Colors.Yellow);
            if(currentTextBox.Name== "txtPrenom")
                txtPrenom.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void txtMouseLeave(object sender, RoutedEventArgs args)
        {
            currentTextBox = sender as TextBox;
            if (currentTextBox.Name == "txtNom")
                txtNom.Background = new SolidColorBrush(Colors.White);
            if (currentTextBox.Name == "txtPrenom")
                txtPrenom.Background = new SolidColorBrush(Colors.White);
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            ;
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }
    }

  
}
