using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_RequestPasswordDL
/// </summary>
public class Mobile_RequestPasswordDL
{
	public void Mobile_RequestPassword(int patientId, string patientPassword)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_RequestPassword", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", patientId);
        cmd.Parameters.Add("@patientPassword", patientPassword);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}