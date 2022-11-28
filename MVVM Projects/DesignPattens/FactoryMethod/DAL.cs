using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPattens.FactoryMethod
{
    public class DAL
    {
        public void Connect(Choice choice)
        {
            switch (choice)
            {
                case Choice.SqlServer:
                    ConnectSqlServer();
                    break;
                case Choice.PostGres:
                    ConnectPostGres();
                    break;
                case Choice.Cloud:
                    ConnectCloud();
                    break;
                default:
                    throw new Exception("Il faut faire le choix de connexion");
            }
        }


        private void ConnectSqlServer()
        {
            Console.WriteLine("Ici vous ajoutez l'implémentation qui accède à SQL Server");
        }

        private void ConnectPostGres()
        {
            Console.WriteLine("Ici vous ajoutez l'implémentation qui accède à PostGres");
        }

        private void ConnectCloud()
        {
            Console.WriteLine("Ici vous ajoutez l'implémentation qui accède à Cloud");
        }
    }

}
