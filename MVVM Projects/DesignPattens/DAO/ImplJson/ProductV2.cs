namespace DesignPattens.Repository.ImplJson
{
    using DesignPattens.DAO.ImplJson;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductV2 : IProduct
    {
        //Vous faites les mises a jour necessaires
        public int ProductID { get; set; }

        public string Name { get; set; }


        public string Color { get; set; }

      
        public decimal? StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
