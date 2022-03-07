using RetailStoreCashRegister.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly SqlConnection _connection;

        public CategoryRepository()
        {
            _connection = DatabaseConnectionFactory.GetInstance().GetConnection();
        }

        public void Delete(Category obj)
        {
            try
            {
                _connection.Open();

                string query = $"DELETE FROM category WHERE id = {obj.Id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                throw new Exception("Unable to delete category.");
            }
        }

        public void DeleteAll()
        {
            try
            {
                _connection.Open();

                string query = "DELETE FROM category";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                _connection.Close();
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception("Unable to delete all categories.");
            }
        }

        public void Insert(Category obj)
        {
            try
            {
                _connection.Open();

                string query = $"INSERT INTO category (name) VALUES ('{obj.Name}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                _connection.Close();
            } catch(Exception e)
            {
                Console.Error.WriteLine(e.Message);
                throw new Exception("Unable to add category.");
            }
            
        }

        public List<Category> SelectAll()
        {
            try
            {
                _connection.Open();

                SqlCommand sqlCmd = new("SELECT * FROM category", _connection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                List<Category> categories = new();
                while (sqlReader.Read())
                {
                    categories.Add(new Category
                    {
                        Id = Convert.ToInt32(sqlReader["id"]),
                        Name = sqlReader["name"].ToString()
                    });
                }

                sqlReader.Close();
                _connection.Close();

                return categories;
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
                throw new Exception("Unable to load categories.");
            }
        }

        public void Update(Category obj)
        {
            try
            {
                _connection.Open();

                string query = $"UPDATE category SET name = '{obj.Name}' WHERE id = {obj.Id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.ExecuteNonQuery();

                _connection.Close();
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex);
                throw new Exception("Unable to update category.");
            }
        }
    }
}
