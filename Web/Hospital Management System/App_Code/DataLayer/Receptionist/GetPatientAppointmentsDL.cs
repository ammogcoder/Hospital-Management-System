using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetPatientAppointmentsDL
/// </summary>
public class GetPatientAppointmentsDL
{
	public DataSet GetPatientAppointments(string appointmentToken)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetPatientAppointments", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentToken", appointmentToken);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}