
namespace ERPProject.Models.ImplJson
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int empid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> hiredate { get; set; }
        public string phone { get; set; }
        public Nullable<int> storeid { get; set; }
    
        public virtual Store Store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
