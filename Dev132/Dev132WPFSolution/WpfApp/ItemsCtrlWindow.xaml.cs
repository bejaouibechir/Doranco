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
        
        private IComparer<Personne> personcomparer;

        public ItemsCtrlWindow()
        {
           
            InitializeComponent();


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
           
            MenuItem item = sender as MenuItem;
            if(item.Name=="asc")
            {
                //Implémente la logique de tri ascendant
                personnes.Sort(personcomparer);
                personnelist.ItemsSource = personnes;
            }
            else
            {
                //Implémente la logique de tri descendant
            }
        }

        string path = @"D:\";

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                List<string> repertoires = new List<string>();
                TreeViewItem treeViewItem = new TreeViewItem { Header = path };
                foreach (string nom_repertoire in Directory.GetDirectories(path))
                {
                    //Première alternative pour alimenter la tree View décommenter la ligne 75
                    //foldersTreeView.Items.Add(nom_repertoire);   

                    //Dans la deuxième alternative pour alimenter la tree view avec les données 
                    //il faut tout d'abord peupler la liste repertoires avec les noms des dossiers
                    //Il faut decommenter la ligne suivante ligne 80 et puis la ligne 83
                    repertoires.Add(nom_repertoire);
            }
                //Deuxième alternative pour alimenter la tree View
                foldersTreeView.ItemsSource = repertoires;

                //PopulateTreeView(foldersTreeView, path);
        }

        /* Cette méthode n'est pas fialisée, son but lorsque elle est appelée au niveau de la ligne 85
         * elle peuple la tree view avec les dossiers et leur  sous dossiers d'une manière récursive 
         *     |
         *     |
         *     v
         */
        private void PopulateTreeView(TreeView treeView,string path)
        {
            List<string> repertoires = new List<string>();
            TreeViewItem treeViewItem = new TreeViewItem { Header = path };
            foreach (string nom_repertoire in Directory.GetDirectories(path))
            {
                //repertoires.Add(nom_repertoire);
                treeViewItem.Items.Add(treeViewItem);
                PopulateTreeView(treeView, nom_repertoire);
            }
            treeView.Items.Add(treeViewItem);
            //foldersTreeView.ItemsSource = repertoires;
        }
    }

    public class PersonComparer : IComparer<Personne>
    {
        public int Compare(Personne x, Personne y)
        {
            return x.CompareTo(y);
        }
    }


    public class MyClass
    {
        public int MyProperty { get; set; }
    }
}
