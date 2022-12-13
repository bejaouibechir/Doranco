using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class Contacts :List<Contact>
    {
        public Contacts()
        {
            Add(new Contact { Firstname = "Bejaoui", Lastname = "Bechir" });
            Add(new Contact { Firstname = "Antoine", Lastname = "Poujaud" });
            Add(new Contact { Firstname = "Baptiste", Lastname = "Bentivoglio" });
            Add(new Contact { Firstname = "Clement", Lastname = "Dupuy" });
            Add(new Contact { Firstname = "Nicolas", Lastname = "Cazo" });
        }
    }
}
