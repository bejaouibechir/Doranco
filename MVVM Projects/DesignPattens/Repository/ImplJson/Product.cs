namespace DesignPattens.Repository.ImplJson
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        [Column(TypeName = "money")]
        public decimal? StandardCost { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
