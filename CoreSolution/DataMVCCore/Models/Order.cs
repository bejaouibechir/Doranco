using System;
using System.Collections.Generic;

namespace DataMVCCore.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public DateTime Orderdate { get; set; }

    public decimal Freight { get; set; }

    public string? Shipcity { get; set; }

    public int? Employeeid { get; set; }

    //Propriété de naviguation
    public virtual Employee? Employee { get; set; }
}
