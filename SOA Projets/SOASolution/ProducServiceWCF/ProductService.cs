using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;


namespace ProducServiceWCF
{

    public class ProductService : IProductService
    {
        ProductModel _context;

        public ProductService()
        {
            _context = new ProductModel();
        }
        
        public void Add(Product product)
        {
            _context.Products.Add(product);
            Debug.WriteLine($"Le produit {product.ProductID} est ajouté à la base ");
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product current = Get(id);
            _context.Products.Remove(current);
            Debug.WriteLine($"Le produit {id} est supprimé à la base ");
            _context.SaveChanges();
        }

        public Product Get(int id)
        {
            Product result = _context.Products.SingleOrDefault(p => p.ProductID == id);
            Debug.WriteLine($"Le produit {id} est retrouné de la base ");
            return result;
        }

        public List<Product> List()
        {
            List<Product> products = _context.Products.ToList();
            Debug.WriteLine($"La liste des produits est retounrée de la base ");
            return products;
        }

        public void Update(int id, Product newproduct)
        {
            Product current = _context.Products.FirstOrDefault(p => p.ProductID == id);
            _context.Products.AddOrUpdate(current, newproduct);
            Debug.WriteLine($"Le produit {id} est mis à jour de la base ");
            _context.SaveChanges();
        }
    }
}
