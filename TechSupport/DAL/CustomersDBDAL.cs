﻿using DisplayIncidents.Model;
using DisplayIncidents;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    public class CustomersDBDAL
    {
    }

    /// <summary>
    /// Get the list of incidents 
    /// </summary>
    /// <returns> the list of incidents </returns> 
    public List<Customer> GetCustomers()
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
}
