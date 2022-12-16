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
using WpfApp.Data;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ItemsCtrlWindow.xaml
    /// </summary>
    public partial class ItemsCtrlWindow : Window
    {
        //Tab listbox   
        MesCouleurs couleurs;
        PersonneList personnes;
        ItemProvider itemProvider = new ItemProvider();
        string path = @"D:\";

        public ItemsCtrlWindow()
        {
           
            InitializeComponent();

            #region TreeView
            var items = itemProvider.GetItems(path);
            DataContext = items;
            #endregion


            #region Listview 

            personnes = new PersonneList();
            personnelist.ItemsSource = personnes;
            #endregion


            #region tab listbox
            //MesCouleurs couleurs = new MesCouleurs();
            couleurs = (MesCouleurs)Resources["couleurs"];
            dynamicList.ItemsSource = couleurs;
            #endregion
        }

        private void Trier_Click(object sender, RoutedEventArgs e)
        {
            CollectionView view;
            MenuItem item = sender as MenuItem;
            if(item.Name=="idasc")
            {
                view = (CollectionView)CollectionViewSource.GetDefaultView(personnelist.ItemsSource);
                view.SortDescriptions.Add(new SortDescription("Id", ListSortDirection.Ascending));
                personnelist.ItemsSource = null;
                personnelist.ItemsSource = view;
            }
            else if(item.Name =="iddsc")
            {
  
                //Implémente la logique de tri ascendant
                view = (CollectionView)CollectionViewSource.GetDefaultView(personnelist.ItemsSource);
                view.SortDescriptions.Add(new SortDescription("Id", ListSortDirection.Descending));
                personnelist.ItemsSource = null;
                personnelist.ItemsSource = view;
            }
        }


        private void Chemin_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
               path = openFileDlg.SelectedPath;
               var items = itemProvider.GetItems("C:\\Temp");
               DataContext = items;
            }
            
        }
    }

}
