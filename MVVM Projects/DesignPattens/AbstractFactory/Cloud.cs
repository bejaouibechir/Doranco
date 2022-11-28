using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.AbstractFactory
{
    public class Cloud :DALBase
    {
        protected Cloud()
        {

        }

        public static DALBase GetInstance()
        {
            return new Cloud();
        }

        public override void Connect()
        {
            Console.WriteLine("Connection à Cloud");
        }
        public override void AddData()
        {
            Console.WriteLine("Ajouter des données à Cloud");
        }
        public override void RemoveData()
        {
            Console.WriteLine("Supprimer des données de Cloud");
        }

        public override void SelectData()
        {
            Console.WriteLine("Slectionner des données de Cloud");
        }
    }
}
