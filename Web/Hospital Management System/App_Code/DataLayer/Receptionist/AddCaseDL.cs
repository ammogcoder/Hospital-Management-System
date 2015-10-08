using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddCaseDL
/// </summary>
public class AddCaseDL
{
    public int AddCase(AddCaseBO objAddCaseBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddCase", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@doctorId", objAddCaseBO.doctorId);
        cmd.Parameters.Add("patientId", objAddCaseBO.patientId);
        cmd.Parameters.Add("@caseStartDate", objAddCaseBO.caseStartDate);
        cmd.Parameters.Add("@caseEndDate", objAddCaseBO.caseEndDate);
        conn.Open();
        int caseId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return caseId;
	}
}