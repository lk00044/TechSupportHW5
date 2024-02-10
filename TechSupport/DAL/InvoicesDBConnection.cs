using System.Data.SqlClient;

namespace DisplayIncidents
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public static class IncidentsDBConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                 "Data Source=localhost;Initial Catalog=Incidents;" +
                "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
