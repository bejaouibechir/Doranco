using System;

namespace DesignPattens.AbstractFactory
{
    public abstract class DALBase
    {
        

        static public DALBase CreateInstance(Choice choice)
        {
            switch (choice)
            {
                case Choice.SqlServer:
                     return SqlServer.GetInstance();
                    
                case Choice.PostGres:
                    return PostgreSQL.GetInstance();
                case Choice.Cloud:
                    return Cloud.GetInstance();
                default:
                    throw new ArgumentException("Il faut choisir un mode d'accès aux données");

            }
        }

        abstract public void AddData();
       abstract public void Connect();
       abstract public void RemoveData();
       abstract public void SelectData();
    }
}