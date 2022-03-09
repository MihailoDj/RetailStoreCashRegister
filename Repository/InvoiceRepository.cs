using RetailStoreCashRegister.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Repository
{
    internal class InvoiceRepository : IRepository<Invoice>
    {
        private readonly SqlConnection _connection;

        public InvoiceRepository()
        {
            _connection = DatabaseConnectionFactory.GetInstance().GetConnection();
        }

        public void Delete(Invoice obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Invoice obj)
        {
            try
            {
                _connection.Open();

                //Insert invoice
                string invoiceQuery = "INSERT INTO invoice (date, total_price) VALUES (@date, @totalPrice);";

                SqlCommand cmdInsertInvoice = new SqlCommand(invoiceQuery, _connection);
                cmdInsertInvoice.Parameters.AddWithValue("@date", obj.BillingDate);
                cmdInsertInvoice.Parameters.AddWithValue("@totalPrice", obj.ComputeTotalPrice());
                cmdInsertInvoice.ExecuteNonQuery();

                //Insert many-many stats relation
                foreach (KeyValuePair<Product, double> product in obj.ProductAmounts)
                {
                    string statsQuery = 
                        "INSERT INTO stats (invoice_id, product_id, amount) "
                        + "VALUES ((SELECT max(id) FROM invoice), @productId, @amount);";

                    SqlCommand cmdInsertStats = new SqlCommand(statsQuery, _connection);
                    cmdInsertStats.Parameters.AddWithValue("@productId", product.Key.Id);
                    cmdInsertStats.Parameters.AddWithValue("@amount", product.Value);
                    cmdInsertStats.ExecuteNonQuery();
                }

                _connection.Close();
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }

        public List<Invoice> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice obj)
        {
            throw new NotImplementedException();
        }
    }
}
