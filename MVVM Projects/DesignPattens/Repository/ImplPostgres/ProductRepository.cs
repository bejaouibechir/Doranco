using DesignPattens.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Repository.ImplPostGres
{

                 //Implémentation    abstraction
    public class ProductRepository : IRepository<Product>
    {
        PostGresModel  _context;

        public ProductRepository()
        {
            _context = new PostGresModel();
        }

        public void Add(Product entity)
        {
            _context.Add(entity);
        }

        public void Delete(Product entity)
        {
            _context.Remove(entity.ProductID);
        }

        public Product Get(int id)
        {
            return _context.Get(id);
        }

        public List<Product> List()
        {
            return _context.List();
        }

        public void Update(Product entity)
        {
            _context.Update(entity.ProductID, entity);
        }
    }


}
