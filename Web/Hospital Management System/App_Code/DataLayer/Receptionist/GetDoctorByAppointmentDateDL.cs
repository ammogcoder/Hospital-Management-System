using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetDoctorByAppointmentDateDL
/// </summary>
public class GetDoctorByAppointmentDateDL
{
	public DataSet GetDoctorByAppointmentDate(string appointmentDate)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetDoctorByAppointmentDate", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("appointmentDate", appointmentDate);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}