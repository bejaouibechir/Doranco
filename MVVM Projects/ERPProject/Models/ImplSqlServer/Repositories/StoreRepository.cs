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
    public class StoreRepository : IRepository<Store>
    {
        BusinessDBEntities _context;

        public StoreRepository()
        {
            _context = new BusinessDBEntities();
        }
        public void Add(Store entity)
        {
            _context.Stores.Add(entity);
        }

        public ObservableCollection<Store> All()
        {
            return new ObservableCollection<Store>(_context.Stores.ToArray());
        }

        public void Delete(Store entity)
        {
            _context.Stores.Remove(entity);
        }

        public Store Get(int id)
        {
            try
            {
                return _context.Stores.SingleOrDefault(s => s.storeid == id);
            }
            catch (Exception)
            {
                 return new Store();
            }
        }

        public void Update(int id, Store newentity)
        {
            Store selectedStore = Get(id);
            _context.Stores.AddOrUpdate(Get(id), selectedStore);
        }
    }
}
