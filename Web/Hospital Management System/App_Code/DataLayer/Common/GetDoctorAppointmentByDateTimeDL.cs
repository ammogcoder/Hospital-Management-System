using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetDoctorAppointmentByDateTimeDL
/// </summary>
public class GetDoctorAppointmentByDateTimeDL
{
	public DataSet GetDoctorAppointmentByDateTime(int empId, string appointmentDate, string appointmentTime)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetDoctorAppointmentByDateTime", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@appointmentDate", appointmentDate);
        cmd.Parameters.Add("@appointmentTime", appointmentTime);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}