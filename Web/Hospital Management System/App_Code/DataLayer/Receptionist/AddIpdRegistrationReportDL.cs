using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddIpdRegistrationReportDL
/// </summary>
public class AddIpdRegistrationReportDL
{
	public string AddIpdRegistrationReport(int empId, int ipdId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddIpdRegistrationReport", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@ipdId", ipdId);
        conn.Open();
        string reportId = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return reportId;
	}
}