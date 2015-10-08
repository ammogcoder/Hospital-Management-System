using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_AddIPDObservationMedicineDL
/// </summary>
public class Doctor_AddIPDObservationMedicineDL
{
    public void Doctor_AddIPDObservationMedicine(Doctor_AddIPDObservationMedicineBO objDoctor_AddIPDObservationMedicineBO)
	{
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_AddIPDObservationMedicine", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationId", objDoctor_AddIPDObservationMedicineBO.ipdObservationId);
        cmd.Parameters.Add("@ipdObservationReportId", objDoctor_AddIPDObservationMedicineBO.ipdObservationReportId);
        cmd.Parameters.Add("@medicineInstructions", objDoctor_AddIPDObservationMedicineBO.medicineInstructions);
        cmd.Parameters.Add("@medicineNameId", objDoctor_AddIPDObservationMedicineBO.medicineNameId);
        cmd.Parameters.Add("@medicineQuantity", objDoctor_AddIPDObservationMedicineBO.medicineQuantity);
        cmd.Parameters.Add("@medicineStartDate", objDoctor_AddIPDObservationMedicineBO.medicineStartDate);
        cmd.Parameters.Add("@medicineStrength", objDoctor_AddIPDObservationMedicineBO.medicineStrength);
        cmd.Parameters.Add("@medicineTypeId", objDoctor_AddIPDObservationMedicineBO.medicineTypeId);
        cmd.Parameters.Add("@numberOfRefills", objDoctor_AddIPDObservationMedicineBO.numberOfRefills);
        cmd.Parameters.Add("@quantityOnRefills", objDoctor_AddIPDObservationMedicineBO.quantityOnRefills);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}