using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;

namespace ProducServiceWCF
{

    public class ProductService : IProductService
    {
        ProductModel _context;

        public ProductService()
        {
            _context = new ProductModel();
        }

        [FaultContract(typeof(SqlException))]
        public void Add(Product product)
        {
            try
            {
                _context.Products.Add(product);
                Debug.WriteLine($"Le produit {product.ProductID} est ajouté à la base ");
                _context.SaveChanges();
            }
            catch (FaultException<SqlException> erreur)
            {
                Debug.WriteLine(erreur.Data);
            }
        }

        [FaultContract(typeof(SqlException))]
        public void Delete(int id)
        {
            try
            {
                Product current = Get(id);
                _context.Products.Remove(current);
                Debug.WriteLine($"Le produit {id} est supprimé à la base ");
                _context.SaveChanges();
            }
            catch (FaultException<SqlException> erreur)
            {
                Debug.WriteLine(erreur.Data);
            }
        }

        [FaultContract(typeof(SqlException))]
        public Product Get(int id)
        {
            try
            {
                Product result = _context.Products.SingleOrDefault(p => p.ProductID == id);
                Debug.WriteLine($"Le produit {id} est retrouné de la base ");
                return result;
            }
            catch (FaultException<SqlException> erreur)
            {
                Debug.WriteLine(erreur.Data);
            }
        }

        [FaultContract(typeof(SqlException))]
        public List<Product> List()
        {
            try
            {
                List<Product> products = _context.Products.ToList();
                Debug.WriteLine($"La liste des produits est retounrée de la base ");
                return products;
            }
            catch (FaultException<SqlException> erreur)
            {
                Debug.WriteLine(erreur.Data);
            }
        }

        [FaultContract(typeof(SqlException))]
        public void Update(int id, Product newproduct)
        {
            try
            {
                Product current = _context.Products.FirstOrDefault(p => p.ProductID == id);
                _context.Products.AddOrUpdate(current, newproduct);
                Debug.WriteLine($"Le produit {id} est mis à jour de la base ");
                _context.SaveChanges();
            }
            catch (FaultException<SqlException> erreur)
            {
                Debug.WriteLine(erreur.Data);
            }
        }
    }
}
