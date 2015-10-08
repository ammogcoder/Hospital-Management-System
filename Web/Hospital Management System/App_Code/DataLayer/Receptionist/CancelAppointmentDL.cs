using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for CancelAppointmentDL
/// </summary>
public class CancelAppointmentDL
{
	public void CancelAppointment(string appointmentToken)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spCancelAppointment", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentToken", appointmentToken);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}