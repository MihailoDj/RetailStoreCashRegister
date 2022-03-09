using RetailStoreCashRegister.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
                cmdInsertInvoice.Parameters.AddWithValue("@date", obj.BillingDate.Date);
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

        public List<Invoice> SelectStatistics(DateTime selectedDate)
        {
            try
            {
                _connection.Open();

                SqlDateTime sdt = new SqlDateTime(selectedDate);
                string sqlDate = $"{sdt.Value.Year}-{sdt.Value.Month}-{sdt.Value.Day}";
                string query = "SELECT p.name as pname, amount, i.id as iid, date from stats s join invoice i "
                    + "ON s.invoice_id=i.id JOIN product p ON p.id=s.product_id WHERE i.date=@sqlDate;";

                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@sqlDate", sqlDate);

                SqlDataReader sqlReader = cmd.ExecuteReader();

                List<Invoice> invoices = new();
                while (sqlReader.Read())
                {
                    int currentId = Convert.ToInt32(sqlReader["iid"]);
                    if (invoices.FirstOrDefault(i => i.Id == currentId) == null)
                    {
                        Invoice invoice = new Invoice
                        {
                            Id = currentId,
                            BillingDate = DateTime.Parse(sqlReader["date"].ToString())
                        };
                        invoice.ProductAmounts.Add(
                        new Product
                        {
                            Name = sqlReader["pname"].ToString()
                        },
                        Convert.ToDouble(sqlReader["amount"])
                        );

                        invoices.Add(invoice);
                    } else
                    {
                        Invoice existentInvoice = invoices.FirstOrDefault(i => i.Id == currentId);
                        existentInvoice.ProductAmounts.Add(
                        new Product
                        {
                            Name = sqlReader["pname"].ToString()
                        },
                        Convert.ToDouble(sqlReader["amount"])
                        );
                    }
                }

                sqlReader.Close();
                _connection.Close();

                return invoices;
            } catch(Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }
    }
}
