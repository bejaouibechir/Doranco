using System;

namespace DesignPattens.DAO.ImplJson
{
    public interface IProduct
    {
        string Color { get; set; }
        decimal ListPrice { get; set; }
        DateTime? ModifiedDate { get; set; }
        string Name { get; set; }
        int ProductID { get; set; }
        decimal? StandardCost { get; set; }
    }
}