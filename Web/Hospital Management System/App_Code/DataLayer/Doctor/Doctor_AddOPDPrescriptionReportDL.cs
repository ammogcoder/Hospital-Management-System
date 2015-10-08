using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddOPDPrescriptionReportDL
/// </summary>
public class AddOPDPrescriptionReportDL
{
    public string AddOPDPrescriptionReport(int empId, string appointmentToken)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddOPDPrescriptionReport", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@appointmentToken", appointmentToken);
        conn.Open();
        string reportId = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return reportId;
	}
}