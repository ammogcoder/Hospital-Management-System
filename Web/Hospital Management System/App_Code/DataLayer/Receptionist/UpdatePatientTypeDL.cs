using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for UpdatePatientTypeDL
/// </summary>
public class UpdatePatientTypeDL
{
	public void UpdatePatientType(int patientId, string patientType)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spUpdatePatientType", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", patientId);
        cmd.Parameters.Add("@patientType", patientType);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}