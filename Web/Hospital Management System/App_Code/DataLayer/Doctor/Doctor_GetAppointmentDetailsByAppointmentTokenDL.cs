using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetAppointmentDetailsByAppointmentTokenDL
/// </summary>
public class Doctor_GetAppointmentDetailsByAppointmentTokenDL
{
	public DataSet Doctor_GetAppointmentDetailsByAppointmentToken(string appointmentToken)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetAppointmentDetailsByAppointmentToken", conn);
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