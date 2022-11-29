//#define factorymethod
//#define abstractfactory
//#define sqlserver
#define postgresql
#define repository
using System;
using System.Collections.Generic;
using DesignPattens.AbstractFactory;
using DesignPattens.FactoryMethod;
using DesignPattens.Repository.Abstraction;

#if sqlserver
using DesignPattens.Repository.ImplSQLServer;
#endif

#if postgresql
using DesignPattens.Repository.ImplPostGres;
#endif

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


#if abstractfactory
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
#endif

#if repository

            IRepository<Product> pRepository = new ProductRepository();
            List<Product> products = pRepository.List();
            ;
#endif
            //ImplPostGres.ProductRepository
            //ImplSqlServer.ProductRepository




        }
    }
}
