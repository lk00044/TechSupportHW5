using Technicians.Model;
using System.Data.SqlClient;
using TechSupport.DAL;

/// <summary>
/// Get the Technician data from database 
/// </summary>

namespace Technicians.DAL
{
    public class TechniciansDBDAL
    {

        public List<Technician> GetTechnicians()
        {
            List<Technician> technicianList = new List<Technician>();

            string selectStatement =
                "SELECT TechID, Name, Email, Phone " +
                "FROM Technicians "
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
                            Technician technician = new Technician();
                            technician.TechID = (int)reader["TechID"];
                            technician.Name = reader["Name"].ToString();
                            technician.Email = reader["Email"].ToString();
                            technician.Phone = reader["Phone"].ToString();                           

                            technicianList.Add(technician);
                        }
                    }
                }
            }
            return technicianList;
        }

        /// <summary>
        /// Gets the technician names.
        /// </summary>
        /// <returns></returns>
        public List<Technician> GetTechnicianNames()
        {
            List<Technician> technicianList = new List<Technician>();

            string selectStatement =
                "SELECT Name, TechID " +
                "FROM Technicians "
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
                            Technician technician = new Technician();
                            technician.TechID = (int)reader["TechID"];
                            technician.Name = reader["Name"].ToString();

                            technicianList.Add(technician);
                        }
                    }
                }
            }
            return technicianList;
        }


        /// <summary>
        /// Gets the technician.
        /// </summary>
        /// <param name="techID">The tech identifier.</param>
        /// <returns>Technician with that tech ID </returns>
        public Technician GetTechnician(int techID)
        {
            Technician tech = new Technician();

            string selectStatement =
               "SELECT TechID, Name, Email, Phone " +
               "FROM Technicians " +
               "WHERE TechID = @TechID "
               ;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@TechID", techID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {                        
                        while (reader.Read())
                        {
                            tech.TechID = (int)reader["TechID"];
                            tech.Name = reader["Name"].ToString();
                            tech.Email = reader["Email"].ToString();
                            tech.Phone = reader["Phone"].ToString();

                        }
                    }
                }
            }
            return tech;
        }
    }
}
