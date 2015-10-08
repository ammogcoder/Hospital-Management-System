using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetUpcomingMedicalTestsDL
/// </summary>
public class Mobile_GetUpcomingMedicalTestsDL
{
	public DataSet Mobile_GetUpcomingMedicalTests(int patientId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_GetUpcomingMedicalTests", conn);
        cmd.Parameters.Add("@patientId", patientId);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}