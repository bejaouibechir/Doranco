//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductServiceREST
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
