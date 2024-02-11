﻿using System.Data.SqlClient;


namespace TechnicianConnection
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public static class TechnicianDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                 "Data Source=localhost;Initial Catalog=Technicians;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}

}