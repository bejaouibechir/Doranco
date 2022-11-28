using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.AbstractFactory
{
    public class SqlServer: DALBase
    {
        protected SqlServer()
        {

        }   
        public static DALBase GetInstance()
        {
            return new SqlServer();
        }
        
        public override void Connect()
        {
            Console.WriteLine("Connection à SQL Server");
        }
        public override void AddData()
        {
            Console.WriteLine("Ajouter des données à SQL Server");
        }
        public override void RemoveData()
        {
            Console.WriteLine("Supprimer des données de SQL Server");
        }

        public override void SelectData()
        {
            Console.WriteLine("Slectionner des données de SQL Server");
        }
    }
}
