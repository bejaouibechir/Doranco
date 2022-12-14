namespace WpfApp
{

    
    public class Contact
    {

        public Contact()
        {

        }


        public Contact(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        

        public override string ToString()
        {
            return $"Nom: {Firstname} Prénom: {Lastname}";
        }
    }
}