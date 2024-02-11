﻿using System.Data.SqlClient;


namespace CustomerConnection
    {
        /// <summary>
        /// Get a connection object. 
        /// </summary>
        public static class CustomerDBConnection
        {
            public static SqlConnection GetConnection()
            {
                string connectionString =
                     "Data Source=localhost;Initial Catalog=Customers;" +
                    "Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionString);

                return connection;
            }
        }
    }

}