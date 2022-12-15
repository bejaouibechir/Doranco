using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{
    public class MesCouleurs : List<string>
    {
        public MesCouleurs()
        {
            Add("Rouge");
            Add("Vert");
            Add("Bleu");
        }
    }
}
