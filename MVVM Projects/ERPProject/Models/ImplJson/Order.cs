//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERPProject.Models.ImplJson
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int orderid { get; set; }
        public System.DateTime orderdate { get; set; }
        public decimal freight { get; set; }
        public string shipcity { get; set; }
        public Nullable<int> employeeid { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
