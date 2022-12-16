using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.Data
{
    public class ItemProvider
    {
        public List<Item> GetItems(string path)
        {
            var items = new List<Item>();

            var dirInfo = new DirectoryInfo(path);



            try
            {
                foreach (var directory in dirInfo.GetDirectories())
                {
                    var item = new DirectoryItem
                    {
                        Name = directory.Name,
                        Path = directory.FullName,
                        Items = GetItems(directory.FullName)
                    };

                    items.Add(item);
                }

                foreach (var file in dirInfo.GetFiles())
                {
                    var item = new FileItem
                    {
                        Name = file.Name,
                        Path = file.FullName
                    };

                    items.Add(item);
                }
            }
            catch (UnauthorizedAccessException erreur)
            {
                Debug.Write(erreur.Message);
            }

            return items;
        }
    }
}
