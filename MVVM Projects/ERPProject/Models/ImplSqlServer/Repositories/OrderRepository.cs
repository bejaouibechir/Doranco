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
    public class OrderRepository : IRepository<Order>
    {
        BusinessDBEntities _context;

        public OrderRepository()
        {
            _context = new BusinessDBEntities();
        }
        public void Add(Order entity)
        {
            _context.Orders.Add(entity);
        }

        public ObservableCollection<Order> All()
        {
            return new ObservableCollection<Order>(_context.Orders.ToArray());
        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }

        public Order Get(int id)
        {
            return _context.Orders.SingleOrDefault(s => s.orderid == id);
        }

        public void Update(int id, Order newentity)
        {
            Order selectedOrder = Get(id);
            _context.Orders.AddOrUpdate(Get(id), selectedOrder);
        }
    }
}
