using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.AbstractFactory
{
    public class PostgreSQL :DALBase
    {

        protected PostgreSQL()
        {

        }

        public static DALBase GetInstance()
        {
            return new PostgreSQL();
        }
        public override void Connect()
        {
            Console.WriteLine("Connection à PostgreSQL");
        }
        public override void AddData()
        {
            Console.WriteLine("Ajouter des données à PostgreSQL");
        }
        public override void RemoveData()
        {
            Console.WriteLine("Supprimer des données de PostgreSQL");
        }

        public override void SelectData()
        {
            Console.WriteLine("Slectionner des données de PostgreSQL");
        }
    }
}
