using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetDoctorNameByAppointmentTokenDL
/// </summary>
public class GetDoctorNameByAppointmentTokenDL
{
    public string GetDoctorNameByAppointmentToken(string appointmentToken)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetDoctorNameByAppointmentToken", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentToken", appointmentToken);
        conn.Open();
        string doctorName = cmd.ExecuteScalar().ToString();
        conn.Close();
        return doctorName;
	}
}