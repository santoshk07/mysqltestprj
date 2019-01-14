using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLTestPrj.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int UnitPrice { get; set; }



    }
}
