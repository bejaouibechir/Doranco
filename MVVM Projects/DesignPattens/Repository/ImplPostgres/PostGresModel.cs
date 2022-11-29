using Npgsql; //
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

namespace DesignPattens.Repository.ImplPostGres
{
    //Implémentation ADO.NET 
    public partial class PostGresModel 
    {
        NpgsqlConnection _connection; 
        string _connectionString;
        NpgsqlCommand _command;
        NpgsqlDataReader _reader;
        string _query;
        public PostGresModel() 
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PostGresModel"].ConnectionString;
            _connection = new NpgsqlConnection(_connectionString);
        }
        
        public void Add(Product product)
        {
            try
            {
                _query = "INSERT INTO public.product(name, color, " +
                    $"standardcost, listprice, modifieddate) VALUES ({product.Name}, " +
                    $"{product.Color}, {product.StandardCost}, {product.ListPrice}, {new DateTime(2022,11,29)})";
                _connection.Open();
                _command = new NpgsqlCommand(_query, _connection);
                _command.ExecuteNonQuery();
                Debug.WriteLine("Le produit est ajouté avec succès");
            }
            catch (NpgsqlException erreur)
            {
                Debug.WriteLine(erreur.Message);
            }
            finally
            {
                _connection.Close();
            }

        }

        public void Update(int id,Product newproduct)
        {
            try
            {
                _query = "UPDATE public.product " +
                    $" SET name={newproduct.Name}, color={newproduct.Color}," +
                    $" standardcost={newproduct.StandardCost}, listprice={newproduct.ListPrice}, " +
                    $" modifieddate={new DateTime(2022, 11, 29)}" +
                    $" WHERE productid = {id};";
                _connection.Open();
                _command = new NpgsqlCommand(_query, _connection);
                _command.ExecuteNonQuery();
                Debug.WriteLine("Le produit est ajouté avec succès");
            }
            catch (NpgsqlException erreur)
            {
                Debug.WriteLine(erreur.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Remove(int id)
        {
            try
            {
                _query = $"DELETE FROM public.product WHERE productid={id};";
                _connection.Open();
                _command = new NpgsqlCommand(_query, _connection);
                _command.ExecuteNonQuery();
                Debug.WriteLine("Le produit est ajouté avec succès");
            }
            catch (NpgsqlException erreur)
            {
                Debug.WriteLine(erreur.Message);
            }
            finally
            {
                _connection.Close();
            }
        }


        public Product Get(int id)
        {
            //Faite le comme exercice
            throw new NotImplementedException("Il faut revoir le code ado.net dans les projets de la" +
                "session accès aux données");
        }

        public List<Product> List()
        {
            List<Product> result = new List<Product>();
            Product temp;
            try
            {
                _query = $"SELECT productid, name, color, standardcost, listprice FROM public.product;";
                _connection.Open();
                _command = new NpgsqlCommand(_query, _connection);
                _reader = _command.ExecuteReader();
                while(_reader.Read())
                {
                    temp = new Product();
                    temp.ProductID = int.Parse(_reader[0].ToString());
                    temp.Name = _reader[1].ToString();
                    temp.Color = _reader[2].ToString();
                    temp.StandardCost = decimal.Parse(_reader[3].ToString());
                    temp.ListPrice = decimal.Parse(_reader[4].ToString());
                    result.Add(temp);
                }

                return result;
            }
            catch (NpgsqlException erreur)
            {
                Debug.WriteLine(erreur.Message);
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }



    }
}
