using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_AddIPDObservationMedicalTestDL
/// </summary>
public class Doctor_AddIPDObservationMedicalTestDL
{
    public void Doctor_AddIPDObservationMedicalTest(Doctor_AddIPDObservationMedicalTestBO objDoctor_AddIPDObservationMedicalTestBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_AddIPDObservationMedicalTest", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationId", objDoctor_AddIPDObservationMedicalTestBO.ipdObservationId);
        cmd.Parameters.Add("@ipdObservationReportId", objDoctor_AddIPDObservationMedicalTestBO.ipdObservationReportId);
        cmd.Parameters.Add("@medicalTestId", objDoctor_AddIPDObservationMedicalTestBO.medicalTestId);
        cmd.Parameters.Add("@medicalTestDate", objDoctor_AddIPDObservationMedicalTestBO.medicalTestDate);
        cmd.Parameters.Add("@medicalTestTime", objDoctor_AddIPDObservationMedicalTestBO.medicalTestTime);
        cmd.Parameters.Add("@remarks", objDoctor_AddIPDObservationMedicalTestBO.remarks);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}