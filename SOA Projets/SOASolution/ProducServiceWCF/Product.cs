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
        [DataMember(Order =1)]
        public int ProductID { get; set; }

        [DataMember(Order =2,Name ="ProductName")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember(Order =3)]
        [StringLength(15)]
        public string Color { get; set; }

        [DataMember(Order =4)]
        [Column(TypeName = "money")]
        public decimal? StandardCost { get; set; }

        [DataMember(Order =5)]
        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [DataMember(Order =6)]
        public DateTime? ModifiedDate { get; set; }

    }
}
