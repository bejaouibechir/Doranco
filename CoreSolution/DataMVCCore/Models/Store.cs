using System;
using System.Collections.Generic;

namespace DataMVCCore.Models;

public partial class Store
{
    public int Storeid { get; set; }

    public string Storename { get; set; } = null!;

    public string? City { get; set; }

    public string? Country { get; set; }


    //Propriété de naviguation 1 Store fait travaillez plusieurs Employees
    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
