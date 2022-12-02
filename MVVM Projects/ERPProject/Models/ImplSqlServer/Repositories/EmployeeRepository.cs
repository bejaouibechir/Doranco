using ERPProject.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace ERPProject.Models.ImplSqlServer
{
    public class EmployeeRepository : IRepository<Employee>
    {
        BusinessDBEntities _context;

        public EmployeeRepository()
        {
            _context = new BusinessDBEntities();
        }
        public void Add(Employee entity)
        {
            _context.Employees.Add(entity);
        }

        public ObservableCollection<Employee> All()
        {
            return new ObservableCollection<Employee>(_context.Employees.ToArray());
        }

        public void Delete(Employee entity)
        {
            _context.Employees.Remove(entity);
        }

        public Employee Get(int id)
        {
            return _context.Employees.SingleOrDefault(s => s.empid == id);
        }

        public void Update(int id, Employee newentity)
        {
            Employee selectedEmployee = Get(id);
            _context.Employees.AddOrUpdate(Get(id), selectedEmployee);
        }
    }
}
