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
               "INSERT INTO Incidents (CustomerID, ProductCode, Title, Description, DateOpened) " +
               "VALUES (@CustomerID, @ProductCode, @Title, @Description, @DateOpened) ";

            SqlConnection connection = DBConnection.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);    

            insertCommand.Parameters.AddWithValue("CustomerID", AnIncident.CustomerID);
            insertCommand.Parameters.AddWithValue("ProductCode", AnIncident.ProductCode);
            insertCommand.Parameters.AddWithValue("Title", AnIncident.Title);
            insertCommand.Parameters.AddWithValue("Description", AnIncident.Description);
            insertCommand.Parameters.AddWithValue("DateOpened", DateTime.Now);

            connection.Open();
            insertCommand.ExecuteNonQuery();
            connection.Close();                

        }

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <param name="addToText">The add to text.</param>
        public void UpdateIncident(int incidentID, string addToText, int? technicianID)
        {
            string updateStatement =
               "UPDATE Incidents " +
               "SET Description = Description + @addToText, " +
                    "TechID = @technicianID " +
               "WHERE IncidentID = @incidentID ";

            SqlConnection connection = DBConnection.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("incidentID", incidentID);
            updateCommand.Parameters.AddWithValue("addToText", addToText);
            updateCommand.Parameters.AddWithValue("technicianID", technicianID);

            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();

        }

        public void CloseIncident(int incidentID)
        {
            DateTime today = DateTime.Now;

            string updateStatement =
               "UPDATE Incidents " +
               "SET DateClosed = @today " +
               "WHERE IncidentID = @incidentID ";

            SqlConnection connection = DBConnection.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("today", today);
            updateCommand.Parameters.AddWithValue("incidentID", incidentID);

            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();

        }

        /// <summary>
        /// Get the list of incidents 
        /// </summary>
        /// <returns> the list of incidents </returns> 
        public List<Incident> GetAllIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, i.DateClosed, " +
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
                            incident.DateClosed = (DateTime)reader["DateClosed"];
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


        public Incident GetCustomerIncident(int incidentID)
        {
           Incident incident = new Incident(); ; 

            string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, i.CustomerID, " +
                "c.Name as CustomerName, t.Name as TechName, i.Title, " +
                "i.TechID, i.Description " +
                "FROM Incidents i " +
                "LEFT JOIN Customers c " +
                "ON i.CustomerID = c.CustomerID " +
                "LEFT JOIN Technicians t " +
                "ON i.TechID = t.TechID " +
                "WHERE i.IncidentID = @incidentID "
                ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("incidentID", incidentID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            incident.ProductCode = reader["ProductCode"].ToString();
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            incident.CustomerName = reader["CustomerName"].ToString();
                            incident.CustomerID = (int)reader["CustomerID"];
                            incident.TechName = reader["TechName"].ToString();
                            incident.Title = reader["Title"].ToString();
                            incident.Description = reader["Description"].ToString();  
                            if (reader.IsDBNull(reader.GetOrdinal("TechID")))
                            {
                                incident.TechID = 0;
                            }
                            else
                            {
                                incident.TechID = (int)reader["TechID"];
                            }
                            
                            
                            
                        }
                    }
                }
            }

            if (incident.CustomerID == 0)
            {
                return null;
            }
            else
            {
                return incident;
            }


            
        }

    }

}
