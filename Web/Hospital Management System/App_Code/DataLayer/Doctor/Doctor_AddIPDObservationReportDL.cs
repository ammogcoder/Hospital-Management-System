using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_AddIPDObservationReportDL
/// </summary>
public class Doctor_AddIPDObservationReportDL
{
    public int Doctor_AddIPDObservationReport(Doctor_AddIPDObservationReportBO objDoctor_AddIPDObservationReportBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_AddIPDObservationReport", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationReportId", objDoctor_AddIPDObservationReportBO.ipdObservationReportId);
        cmd.Parameters.Add("@ipdObservationId", objDoctor_AddIPDObservationReportBO.ipdObservationId);
        cmd.Parameters.Add("@problem", objDoctor_AddIPDObservationReportBO.problem);
        cmd.Parameters.Add("@problemDetails", objDoctor_AddIPDObservationReportBO.problemDetails);
        cmd.Parameters.Add("@systemReview", objDoctor_AddIPDObservationReportBO.systemReview);
        cmd.Parameters.Add("@assessment", objDoctor_AddIPDObservationReportBO.assessment);
        cmd.Parameters.Add("@plan", objDoctor_AddIPDObservationReportBO.plan);

        conn.Open();
        int ipdObservationReportId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return ipdObservationReportId;
	}
}