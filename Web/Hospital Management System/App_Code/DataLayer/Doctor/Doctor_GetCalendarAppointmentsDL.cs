using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetCalendarAppointmentsDL
/// </summary>
public class Doctor_GetCalendarAppointmentsDL
{
	public DataSet Doctor_GetCalendarAppointments(int doctorId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetCalendarAppointments", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        cmd.Parameters.Add("doctorId", doctorId);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}