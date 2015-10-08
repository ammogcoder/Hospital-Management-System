using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_DeleteIPDObservationMedicineDL
/// </summary>
public class Doctor_DeleteIPDObservationMedicineDL
{
    public void Doctor_DeleteIPDObservationMedicine(int ipdObservationMedicineId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_DeleteIPDObservationMedicine", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationMedicineId", ipdObservationMedicineId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}