using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DeleteTreatmentMedicineBL
/// </summary>
public class Doctor_DeleteOPDTreatmentMedicineDL
{
	public void Doctor_DeleteOPDTreatmentMedicine(int treatmentMedicineId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spDeleteTreatmentMedicine", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@treatmentMedicineId", treatmentMedicineId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}