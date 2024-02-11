using DisplayIncidents.Model;
using System.Data.SqlClient;

// Leslie Keller

namespace DisplayIncidents.DAL
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

            using (SqlConnection connection = IncidentsDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@IncidentID", AnIncident.IncidentID);
                    insertCommand.Parameters.AddWithValue("@CustomerID", AnIncident.CustomerID);
                    insertCommand.Parameters.AddWithValue("@ProductCode", AnIncident.ProductCode);
                    insertCommand.Parameters.AddWithValue("@TechID", AnIncident.TechID);
                    insertCommand.Parameters.AddWithValue("@DateOpened", AnIncident.DateOpened);
                    insertCommand.Parameters.AddWithValue("@DateClosed", AnIncident.DateClosed);
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
                "SELECT Incidents.IncidentID, Incidents.CustomerID, Incidents.ProductCode, " +
                "Incidents.TechID, Incidents.DateOpened, Incidents.DateClosed " +
                "Incidents.Title, Incidents.Description " +
                "FROM Incidents "
                ;

            using (SqlConnection connection = IncidentsDBConnection.GetConnection())
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
                            incident.TechID = (int)reader["TechID"];
                            incident.DateOpened = (DateTime)reader["DateOpened"];
                            incident.DateClosed = (DateTime)reader["DateClosed"];
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
        public List<Incident> GetMatchingIncidents(int SearchID)
        {
            List<Incident> matchingIncidentList = new List<Incident>();
            matchingIncidentList = this.GetIncidents();

            return matchingIncidentList.FindAll(incident => (incident.DateClosed == null || incident.DateClosed == DateTime.MinValue));
        }

    }



}
