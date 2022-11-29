using DesignPattens.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Repository.ImplSQLServer
{

                 //Implémentation    abstraction
    public class ProductRepository : IRepository<Product>
    {
        SqlServerModel _context;

        public ProductRepository()
        {
            _context = new SqlServerModel();
        }

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
        }

        public Product Get(int id)
        {
            return _context.Products.SingleOrDefault(p => p.ProductID == id);
        }

        public List<Product> List()
        {
            return _context.Products.ToList();
        }

        public void Update(Product entity)
        {
            _context.Products.AddOrUpdate(entity);
        }
    }


}
