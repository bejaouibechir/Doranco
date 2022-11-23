using System;
using System.Web.Services.Description;

namespace ProductService
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public DateTime  CreationDate { get; set; } = DateTime.Now;
    }
}