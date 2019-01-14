using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLTestPrj.Models
{
    public class ProductStoreContext
    {
        public string ConnectionString { get; set; }
        public ProductStoreContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            //ConnectionString = "Server=sanmysql.mysql.database.azure.com; Port=3306; Database=ProductMaster; Uid=santosh@sanmysql; Pwd=Vivaan2014##; SslMode=Preferred;";
            return new MySqlConnection(ConnectionString);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            using (MySqlConnection con = GetConnection())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from product", con);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            ProductName = reader["ProductName"].ToString(),
                            Category = reader["Category"].ToString(),
                            UnitPrice = Convert.ToInt32(reader["UnitPrice"])
                        });
                    }
                }
            }
            return list;
        }
    }
}

