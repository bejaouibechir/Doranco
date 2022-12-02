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
    public class StoreRepository : IRepository<Store>
    {
        JsonModel<Store> _context;

        public StoreRepository()
        {
            _context = new JsonModel<Store>();
        }
        public void Add(Store entity)
        {
            _context.Add(entity);
        }

        public ObservableCollection<Store> All()
        {
            return new ObservableCollection<Store>(_context.GetAll().ToArray());
        }

        public void Delete(Store entity)
        {
            _context.Delete(entity.storeid);
        }

        public Store Get(int id)
        {
            return _context.Get(id);
        }

        public void Update(int id, Store newentity)
        {
            _context.Update(id, newentity);
        }
    }
}
