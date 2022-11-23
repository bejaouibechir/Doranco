using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProductService
{
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService //:WebService (utilisé au cas ou le client est une application web qui nécesite de garder les informations utilisateurs sous forme de cookies(browser) ou sessions(côté serveur))
    {
        string _connstring = "Data Source=PC2022;Initial Catalog=ProductDB;Integrated Security=true";
        //On utilise ADO.NET connecté 
        SqlConnection _connection;
        SqlCommand _command;
        string _query = string.Empty;
        SqlDataReader _reader;

        public ProductService()
        {
            _connection = new SqlConnection(_connstring);
        }


        [WebMethod]
        public void Add(Product product)
        {
            try //Block try
            {
                _query = "INSERT INTO [dbo].[Product]([Name],[Color],[StandardCost],[ListPrice],[ModifiedDate])" +
                        $" VALUES('{product.Name}','{product.Color}',{product.Cost},{product.Price},'{product.CreationDate}')";
                _connection.Open();
                _command = new SqlCommand(_query, _connection);
                _command.ExecuteNonQuery();
                Debug.WriteLine($"Le produit avec Id: {product.Id} est ajouté à la base ProductDB");
            }
            catch (SqlException ex) //Block catch
            {
                Debug.WriteLine($"Quelques choses ne va pas");
                Debug.WriteLine($"Message: {ex.Message}");
            }
            finally //Block final executé dans les deux situations
            {
                _connection.Close();
            }
        }

        [WebMethod]
        public void Update(int id, Product newProduct)
        {   
            try //Block try
            {
                _query = "UPDATE [dbo].[Product]" +
                $" SET [Name] = '{newProduct.Name}'" +
                $",[Color] = '{newProduct.Color}'" +
                $",[StandardCost] = {newProduct.Cost}" +
                $",[ListPrice] = {newProduct.Price}" +
                $",[ModifiedDate] = '{newProduct.CreationDate}'" +
                $" WHERE [ProductID] = {id}";
                _connection.Open();
                _command = new SqlCommand(_query, _connection);
                _command.ExecuteNonQuery();
                Debug.WriteLine($"Le produit avec Id: {id} est mis à jour à la base ProductDB");
            }
            catch (SqlException ex) //Block catch
            {
                Debug.WriteLine($"Quelques choses ne va pas");
                Debug.WriteLine($"Message: {ex.Message}");
            }
            finally //Block final executé dans les deux situations
            {
                _connection.Close();
            }
        }
        [WebMethod]
        public void Delete(int id)
        {
           
            try //Block try
            {
                _query = $"DELETE [dbo].[Product] WHERE [ProductID] = {id} ";
                _connection.Open();
                _command = new SqlCommand(_query, _connection);
                _command.ExecuteNonQuery();
                Debug.WriteLine($"Le produit avec Id: {id} est mis à jour à la base ProductDB");
            }
            catch (SqlException ex) //Block catch
            {
                Debug.WriteLine($"Quelques choses ne va pas");
                Debug.WriteLine($"Message: {ex.Message}");
            }
            finally //Block final executé dans les deux situations
            {
                _connection.Close();
            }
        }

        [WebMethod]
        public Product Get(int id)
        {   
            Product product = new Product();
            _query = $"SELECT [ProductID],[Name],[Color],[StandardCost]," +
                $"[ListPrice],[ModifiedDate] FROM [dbo].[Product] WHERE [ProductID]={id}";

            _connection.Open();
            _command = new SqlCommand(_query, _connection);
            _reader = _command.ExecuteReader();
            _reader.Read();
            product.Id = int.Parse(_reader["ProductID"].ToString());
            product.Name = _reader[1].ToString();
            product.Color = _reader[2].ToString();
            //Si les valeurs nulles sont permise au niveau de la base
            decimal cost;
            decimal.TryParse(_reader[3].ToString(),out cost);
            product.Cost = cost;
            product.Price = decimal.Parse(_reader[4].ToString());
            product.CreationDate = DateTime.Parse(_reader[5].ToString());

            return product;
        }


        [WebMethod]
        public List<Product> List()
        {
            _query = "SELECT [ProductID],[Name],[Color],[StandardCost]" +
                ",[ListPrice],[ModifiedDate] FROM [dbo].[Product]";

            List<Product> products = new List<Product>();
            Product product;
            _command = new SqlCommand(_query, _connection);
            _connection.Open();
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                product = new Product();
                product.Id = int.Parse(_reader[0].ToString());
                product.Name = _reader[1].ToString();
                product.Color = _reader[2].ToString();
                //Si les valeurs nulles sont permise au niveau de la base
                decimal cost;
                decimal.TryParse(_reader[3].ToString(), out cost);
                product.Cost = cost;
                product.Price = decimal.Parse(_reader[4].ToString());
                product.CreationDate = DateTime.Parse(_reader[5].ToString());

                products.Add(product);

            }

            return products;
        }
    }
}
