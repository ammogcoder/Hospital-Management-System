using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetAppointmentsByDateDL
/// </summary>
public class Doctor_GetAppointmentsByDateDL
{
    public DataSet Doctor_GetAppointmentsByDate(int doctorId, string appointmentDate)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetAppointmentsByDate", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("doctorId", doctorId);
        cmd.Parameters.Add("appointmentDate", appointmentDate);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}