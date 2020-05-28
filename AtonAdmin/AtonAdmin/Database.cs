using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtonAdmin {
    class Database {
        static internal MySqlConnection GetConnection() {
            string url = "server=localhost;database=atondb;uid=root;pwd=;";
            return new MySqlConnection(url);
        }
    }
}
