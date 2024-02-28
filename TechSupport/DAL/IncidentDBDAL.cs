using DisplayDBIncidents.Controller;
using Incidents.Model;
using System.Data.SqlClient;
using TechSupport.Controller;
using TechSupport.DAL;

// Leslie Keller

namespace Incidents.DAL
{
    public class IncidentDBDAL
    {
        private CustomerDBController _customerController;
        private ProductDBController _productController;

        /// <summary>
        /// Add an AnIncident to the Incidents database8
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident AnIncident)
        {
            string insertStatement =
               "INSERT CustomerID, ProductCode, Title, Description, DateOpened " +
               "VALUES @CustomerID, @ProductCode, @Title, @Description, DateTime.Now ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CustomerID", AnIncident.CustomerID);
                    insertCommand.Parameters.AddWithValue("@ProductCode", AnIncident.ProductCode);
                    insertCommand.Parameters.AddWithValue("@Title", AnIncident.Title);
                    insertCommand.Parameters.AddWithValue("@Description", AnIncident.Description);
                }
            }

        }

        /// <summary>
        /// Get the list of incidents 
        /// </summary>
        /// <returns> the list of incidents </returns> 
        public List<Incident> GetAllIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, " +
                "c.Name as CustomerName, t.Name as TechName, i.Title " +
                "FROM Incidents i " +
                "LEFT JOIN Customers c " +
                "ON i.CustomerID = c.CustomerID " +
                "LEFT JOIN Technicians t " +
                "ON i.TechID = t.TechID " 
                ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Incident incident = new Incident();
                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            incident.CustomerName = reader["CustomerName"].ToString();
                            incident.TechName = reader["TechName"].ToString();
                            incident.Title = reader["Title"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }

        /// <summary>
        /// Get the list of incidents that match the SearchID 
        /// </summary>
        /// <param UserName="SearchID"></param>
        /// <returns>_matchingIncidents - the list that matches the SearchID </returns>
        public List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, " +
                "c.Name as CustomerName, t.Name as TechName, i.Title " +
                "FROM Incidents i " +   
                "LEFT JOIN Customers c " +
                "ON i.CustomerID = c.CustomerID " +
                "LEFT JOIN Technicians t " +
                "ON i.TechID = t.TechID " +
                "WHERE i.DateClosed IS NULL " 
                ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Incident incident = new Incident();
                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            incident.CustomerName = reader["CustomerName"].ToString();                            
                            incident.TechName = reader["TechName"].ToString() ;                      
                            incident.Title = reader["Title"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
        }

    }

}
