using DesignPattens.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Repository.ImplJson
{
    public class ProductRepository : IRepository<Product>
    {
        JsonModel<Product> _context;

        public ProductRepository()
        {
            _context = new JsonModel<Product>();
        }
        public void Add(Product entity)
        {
            _context.Add(entity);
        }

        public void Delete(Product entity)
        {
            _context.Delete(entity.ProductID);
        }

        public Product Get(int id)
        {
            return _context.Get(id);
        }

        public List<Product> List()
        {
            return _context.GetAll();
        }

        public void Update(Product entity)
        {
            _context.Update(entity.ProductID, entity);
        }
    }
}
