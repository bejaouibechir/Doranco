using MonProjetWPF.Model;
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
    /// Interaction logic for EleventhWindow.xaml
    /// </summary>
    public partial class EleventhWindow : Window
    {
        public EleventhWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employees employees = (Employees)Resources["employees"];
            employees.Add(new Employee {Id=4,Name="Jerome", Age=11, Salary=4500 });
            //employeeList.ItemsSource = employees;
        }
    }
}
