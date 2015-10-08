using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_DeleteIPDObservationMedicalTestDL
/// </summary>
public class Doctor_DeleteIPDObservationMedicalTestDL
{
	public void Doctor_DeleteIPDObservationMedicalTest(int ipdObservationMedicalTestId)
	{
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_DeleteIPDObservationMedicalTest", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationMedicalTestId", ipdObservationMedicalTestId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}