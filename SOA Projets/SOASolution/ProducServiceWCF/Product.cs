namespace ProducServiceWCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Product")]
    [DataContract]
    public partial class Product
    {
        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        [StringLength(15)]
        public string Color { get; set; }

        [DataMember]
        [Column(TypeName = "money")]
        public decimal? StandardCost { get; set; }

        [DataMember]
        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [DataMember]
        public DateTime? ModifiedDate { get; set; }
    }
}
