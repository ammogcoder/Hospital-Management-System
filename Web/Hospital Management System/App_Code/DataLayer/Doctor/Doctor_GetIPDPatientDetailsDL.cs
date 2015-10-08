using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDPatientDetailsDL
/// </summary>
public class Doctor_GetIPDPatientDetailsDL
{
	public DataSet Doctor_GetIPDPatientDetails(int patientId, int doctorId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetIPDPatientDetails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", patientId);
        cmd.Parameters.Add("@doctorId", doctorId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}