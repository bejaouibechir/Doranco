using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject
{
    public class ProductList :List<Product>,IModel
    {
        public ProductList()
        {
            Add(new Product { ProductID = 1, Name = "ProduitA", Color = "Red" });
            Add(new Product { ProductID = 2, Name = "ProduitB", Color = "Green" });
            Add(new Product { ProductID = 3, Name = "ProduitC", Color = "Blue" });
            Add(new Product { ProductID = 4, Name = "ProduitD", Color = "Yellow" });

            //Ajoute du code pour alimenter Products
        }

        public DbSet<Product> Products { get; set; }
    }
}
