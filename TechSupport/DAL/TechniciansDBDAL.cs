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
    }
}
