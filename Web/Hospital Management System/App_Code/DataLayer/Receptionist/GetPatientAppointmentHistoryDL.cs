using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetPatientAppointmentHistoryDL
/// </summary>
public class GetPatientAppointmentHistoryDL
{
	public DataSet GetPatientAppointmentHistory(int patientId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetPatientAppointmentHistory", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", patientId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}