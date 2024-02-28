using Incidents.Model;
using System.Data.SqlClient;
using TechSupport.DAL;

// Leslie Keller

namespace Incidents.DAL
{
    public class IncidentDBDAL
    {        

        /// <summary>
        /// Add an AnIncident to the Incidents database
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddIncident(Incident AnIncident)
        {
            if (AnIncident == null)
                throw new ArgumentNullException("Incident cannot be null.");

            string insertStatement =
               "INSERT IncidentID, CustomerID, ProductCode, " +
               "TechID, DateOpened, DateClosed " +
               "Title, Description " +
               "VALUES @IncidentID, @CustomerID, @ProductCode, " +
               "@TechID, @DateOpened, @DateClosed, " +
               "@Title, @Description ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CustomerID", AnIncident.CustomerID);
                    insertCommand.Parameters.AddWithValue("@ProductCode", AnIncident.ProductCode);
                    insertCommand.Parameters.AddWithValue("@TechID", AnIncident.TechID);
                    insertCommand.Parameters.AddWithValue("@DateOpened", AnIncident.DateOpened);
                    insertCommand.Parameters.AddWithValue("@Title", AnIncident.Title);
                    insertCommand.Parameters.AddWithValue("@Description", AnIncident.Description);
                }
            }

        }

        /// <summary>
        /// Get the list of incidents 
        /// </summary>
        /// <returns> the list of incidents </returns> 
        public List<Incident> GetIncidents()
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =
                "SELECT IncidentID, CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description " +
                "FROM Incidents "
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
                            incident.IncidentID = (int)reader["IncidentID"];
                            incident.CustomerID = (int)reader["CustomerID"];
                            incident.ProductCode = reader["ProductCode"].ToString();
                           // incident.TechID = (int)reader["TechID"];
  
                            if (reader["TechID"] is not DBNull)
                            {
                                  incident.TechID  = Convert.ToInt32(reader["TechID"]);                               
                            }

                            incident.DateOpened = (DateTime)reader["DateOpened"];
                          //  incident.DateClosed = (DateTime)reader["DateClosed"]; ;
                            
                            if (reader["DateClosed"] is DBNull)
                            {
                                incident.DateClosed = null;
                            } 
                            else
                            {
                                incident.DateClosed = (DateTime?)reader["DateClosed"];                                
                            }
                             
                            incident.Title = reader["Title"].ToString();
                            incident.Description = reader["Description"].ToString();

                            incidentList.Add(incident);
                        }
                    }
                }
            }
            return incidentList;
            //  return _incidents;
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
