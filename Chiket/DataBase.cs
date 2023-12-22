using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiket
{
    public class Database
    {
        private static readonly string connectionString = "Server=SERVER_BIT;user=user1;password=userdb1;Database=demEkz";

        public static string GetConnectionString()
        {
            return connectionString;
        }

        // Указать свою БД
    }
}
