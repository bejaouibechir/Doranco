using ERPProject.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace ERPProject.Models.ImplJson
{
    public class EmployeeRepository : IRepository<Employee>
    {
        JsonModel<Employee> _context;

        public EmployeeRepository()
        {
            _context = new JsonModel<Employee>();
        }
        public void Add(Employee entity)
        {
            _context.Add(entity);
        }

        public ObservableCollection<Employee> All()
        {
            return new ObservableCollection<Employee>(_context.GetAll());
        }

        public void Delete(Employee entity)
        {
            _context.Delete(entity.empid);
        }

        public Employee Get(int id)
        {
            return _context.Get(id);
        }

        public void Update(int id, Employee newentity)
        {
            _context.Update(id, newentity);
        }
    }
}
