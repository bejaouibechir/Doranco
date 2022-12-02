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
    public class OrderRepository : IRepository<Order>
    {
        JsonModel<Order> _context;

        public OrderRepository()
        {
            _context = new JsonModel<Order>();
        }
        public void Add(Order entity)
        {
            _context.Add(entity);
        }

        public ObservableCollection<Order> All()
        {
            return new ObservableCollection<Order>(_context.GetAll());
        }

        public void Delete(Order entity)
        {
            _context.Delete(entity.orderid);
        }

        public Order Get(int id)
        {
            return _context.Get(id);
        }

        public void Update(int id, Order newentity)
        {
            _context.Update(id, newentity);
        }
    }
}
