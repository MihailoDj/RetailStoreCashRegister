using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Repository
{
    public class DatabaseConnectionFactory
    {
        private static DatabaseConnectionFactory _instance;
        private readonly string _connectionString = "Data Source=DESKTOP-8l0KR0H;Initial Catalog=retail_store;Integrated Security=True";
        private SqlConnection _connection;

        private DatabaseConnectionFactory() { }

        public static DatabaseConnectionFactory Instance()
        {
            if (_instance is null)
                _instance = new DatabaseConnectionFactory();
            return _instance;
        }

        public SqlConnection GetConnection()
        {
            if (_connection == null)
                _connection = new SqlConnection(_connectionString);

            return _connection;
        }
    }
}
