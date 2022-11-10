using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjetWPF.Model
{
    public class Employees :List<Employee>
    {
        public Employees()
        {
            Add(new Employee { Id = 1, Name = "moi", Age = 44,Salary=5000 });
            Add(new Employee { Id = 2, Name = "lui", Age = 30,Salary=4000 });
            Add(new Employee { Id = 3, Name = "elle", Age = 25,Salary=2000 });
        }
    }
}
