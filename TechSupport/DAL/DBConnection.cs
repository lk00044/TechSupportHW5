using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    public static class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                 "Data Source=CSDBLAB-VM04;Initial Catalog=TechSupport;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
