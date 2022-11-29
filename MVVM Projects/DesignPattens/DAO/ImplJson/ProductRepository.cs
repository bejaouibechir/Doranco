using DesignPattens.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.DAO.ImplJson
{
    public class ProductRepository : IRepository<IProduct>
    {
        JsonModel<IProduct> _context;

        public ProductRepository()
        {
            _context = new JsonModel<IProduct>();
        }
        public void Add(IProduct entity)
        {
            _context.Add(entity);
        }

        public void Delete(IProduct entity)
        {
            _context.Delete(entity.ProductID);
        }

        public IProduct Get(int id)
        {
            return _context.Get(id);
        }

        public List<IProduct> List()
        {
            return _context.GetAll();
        }

        public void Update(IProduct entity)
        {
            _context.Update(entity.ProductID, entity);
        }
    }
}
