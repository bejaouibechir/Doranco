using System;
using System.Collections.Generic;

namespace DataMVCCore.Models;

public partial class Employee
{
    public int Empid { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Title { get; set; }

    public DateTime? Hiredate { get; set; }

    public string? Phone { get; set; }

    public int? Storeid { get; set; }

    //Propriété de naviguation
    public virtual ICollection<Order> Orders { get; } = new List<Order>();
    //Propriété de naviguation
    public virtual Store? Store { get; set; }
}
