using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        
        //Mode connecté 
        static void Main(string[] args)
        {
            string chaineconnection = "Data Source=PC2022;Initial Catalog=AdventureWorksLT2014;Integrated Security=True";
            SqlConnection connection = new SqlConnection(chaineconnection);
            SqlCommand command = new SqlCommand("SELECT TOP(20) [ProductID],[Name],[Color]," +
                "[ListPrice],[Weight] FROM [SalesLT].[Product]", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Produit produit;
            //code pour peupler la liste produits
            while (reader.Read())
            {
                produit = new Produit();
                produit.Id = int.Parse(reader[0].ToString());
                produit.Name = reader[1].ToString();
                produit.Color = reader[2].ToString();
                produit.ListPrice = decimal.Parse(reader[3].ToString());
                decimal weightValue;
                decimal.TryParse(reader[4].ToString(), out weightValue);
                produit.Weight = weightValue;
                Console.WriteLine(produit);
            }
            Console.ReadLine();
        }
    }

    public class Produit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        public decimal Weight { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Color: {Color},Price: {ListPrice} and Weight {Weight}";
        }
    }
}
