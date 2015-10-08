using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_DeleteIPDObservationReportDL
/// </summary>
public class Doctor_DeleteIPDObservationReportDL
{
	public void Doctor_DeleteIPDObservationReport(int ipdObservationReportId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_DeleteIPDObservationReport", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationReportId", ipdObservationReportId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}