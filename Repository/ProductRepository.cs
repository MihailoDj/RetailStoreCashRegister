using RetailStoreCashRegister.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly SqlConnection _connection;

        public ProductRepository()
        {
            _connection = DatabaseConnectionFactory.GetInstance().GetConnection();
        }
        public void Delete(Product obj)
        {
            try
            {
                _connection.Open();

                string query = "DELETE FROM product WHERE id=@id;";

                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@id", obj.Id);

                cmd.ExecuteNonQuery();

                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new Exception("Unable to delete product");
            }
        }

        public void DeleteAll()
        {
            try
            {
                _connection.Open();

                string query = "DELETE FROM product";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new Exception("Unable to delete all products.");
            }
        }

        public void Insert(Product obj)
        {
            try
            {
                _connection.Open();

                string query = "INSERT INTO product (price, unit_of_measure, name, category_id) VALUES (@price, @unitOfMeasure, @name, @categoryId);";

                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@unitOfMeasure", obj.UnitOfMeasure.ToString());
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@categoryId", obj.Category.Id);

                cmd.ExecuteNonQuery();

                _connection.Close();
            }catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new Exception("Unable to update product.");
            }
        }

        public List<Product> SelectAll()
        {
            try
            {
                _connection.Open();

                SqlCommand sqlCmd = new("SELECT p.id as pid, p.name as pname, p.price, p.unit_of_measure," 
                    + " c.id as cid, c.name as cname" 
                    + " FROM product p JOIN category c ON (p.category_id = c.id)", _connection);

                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                List<Product> products = new();
                while (sqlReader.Read())
                {
                    products.Add(new Product
                    {
                        Id = Convert.ToInt32(sqlReader["pid"]),
                        Name = sqlReader["pname"].ToString(),
                        Price = Convert.ToDouble(sqlReader["price"]),
                        UnitOfMeasure = (Enums.UnitOfMeasure)Enum.Parse(typeof(Enums.UnitOfMeasure), Convert.ToString(sqlReader["unit_of_measure"])),
                        Category = new Category
                        {
                            Id = Convert.ToInt32(sqlReader["cid"]),
                            Name = sqlReader["cname"].ToString()
                        }
                    });
                }

                sqlReader.Close();
                _connection.Close();

                return products;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                throw new Exception("Unable to load products.");
            }
        }

        public void Update(Product obj)
        {
            try
            {
                _connection.Open();

                string query = "UPDATE product SET price=@price, unit_of_measure=@unitOfMeasure, name=@name, category_id=@categoryId WHERE id=@id;";

                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@id", obj.Id);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@unitOfMeasure", obj.UnitOfMeasure.ToString());
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@categoryId", obj.Category.Id);

                cmd.ExecuteNonQuery();

                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw new Exception("Unable to add product.");
            }
        }
    }
}
