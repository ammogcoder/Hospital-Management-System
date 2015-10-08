using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetUpcomingAppointmentsCountDL
/// </summary>
public class Mobile_GetUpcomingAppointmentsCountDL
{
    public string Mobile_GetUpcomingAppointmentsCount(string patientId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_GetUpcomingAppointmentsCount", conn);
        cmd.Parameters.Add("@patientId", patientId);
        cmd.CommandType = CommandType.StoredProcedure;
        conn.Open();
        string appointmentCount = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return appointmentCount;
	}
}