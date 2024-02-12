using System.Data.SqlClient;

namespace Incidents
{
    /// <summary>
    /// Get a connection object. 
    /// </summary>
    public static class IncidentsDBConnection
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
