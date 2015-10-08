using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetDoctorAppointmentsByIdDL
/// </summary>
public class GetDoctorAppointmentsByIdDL
{
	public DataSet GetDoctorAppointmentsById(int doctorId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetDoctorAppointmentsById", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@doctorId", doctorId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}