using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace cramschool
{
    internal class DB
    {
        public static SqlConnection cramschool()
        {
            string connectionString = "Data Source=LAPTOP-2JJ054OC; Initial catalog=cramschool; Integrated Security=true; Encrypt=false";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
