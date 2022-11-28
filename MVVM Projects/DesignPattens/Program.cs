//#define factorymethod
using System;
using DesignPattens.AbstractFactory;
using DesignPattens.FactoryMethod;

namespace DesignPattens
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if factorymethod
            DAL dataaccesslayer = new DAL();
            dataaccesslayer.Connect(Choice.PostGres);
#endif

            //Forme  erronée
            /*SqlServer alternative1 = new SqlServer();
            PostgreSQL alternative2 = new PostgreSQL();
            Cloud alternative3 = new Cloud();*/

            DALBase dalsqlserver = DALBase.CreateInstance(AbstractFactory.Choice.SqlServer);
            dalsqlserver.Connect();
            DALBase dalpostgresql = DALBase.CreateInstance(AbstractFactory.Choice.PostGres);
            dalpostgresql.Connect();
            DALBase dalcloud = DALBase.CreateInstance(AbstractFactory.Choice.Cloud);
            dalcloud.Connect();
        }
    }
}
