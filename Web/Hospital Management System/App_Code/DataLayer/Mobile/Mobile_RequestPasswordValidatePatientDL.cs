using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_RequestPasswordValidatePatientDL
/// </summary>
public class Mobile_RequestPasswordValidatePatientDL
{
    public int Mobile_RequestPasswordValidatePatient(string patientPhone, string patientDOB)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_RequestPasswordValidatePatient", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientPhone", patientPhone);
        cmd.Parameters.Add("@patientDOB", patientDOB);
        conn.Open();
        int patientId = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        conn.Close();
        return patientId;
	}
}