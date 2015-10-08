using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddOPDTreatmentDL
/// </summary>
public class AddOPDTreatmentDL
{
    public void AddOPDTreatment(Doctor_AddOPDTreatmentBO objAddOPDTreatmentBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddOPDTreatment", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentToken", objAddOPDTreatmentBO.appointmentToken);
        cmd.Parameters.Add("@treatmentDiagnosis", objAddOPDTreatmentBO.treatmentDiagnosis);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}