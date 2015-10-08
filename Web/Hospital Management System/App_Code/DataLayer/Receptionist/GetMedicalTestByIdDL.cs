using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetMedicalTestByIdDL
/// </summary>
public class GetMedicalTestByIdDL
{
	public string GetMedicalTestById(int medicalTestId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetMedicalTestById", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@medicalTestId", medicalTestId);
        conn.Open();
        string medicalTest = cmd.ExecuteScalar().ToString();
        conn.Close();
        return medicalTest;
	}
}