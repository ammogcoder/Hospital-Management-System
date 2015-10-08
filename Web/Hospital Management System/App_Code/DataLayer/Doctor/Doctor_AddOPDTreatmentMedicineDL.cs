using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddOPDTreatmentMedicineDL
/// </summary>
public class AddOPDTreatmentMedicineDL
{
    public void AddOPDTreatmentMedicine(Doctor_AddOPDTreatmentMedicineBO objAddOPDTreatmentMedicineBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddOPDTreatmentMedicine", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentToken", objAddOPDTreatmentMedicineBO.appointmentToken);
        cmd.Parameters.Add("@medicineInstructions", objAddOPDTreatmentMedicineBO.medicineInstructions);
        cmd.Parameters.Add("@medicineNameId", objAddOPDTreatmentMedicineBO.medicineNameId);
        cmd.Parameters.Add("@medicineQuantity", objAddOPDTreatmentMedicineBO.medicineQuantity);
        cmd.Parameters.Add("@medicineStartDate", objAddOPDTreatmentMedicineBO.medicineStartDate);
        cmd.Parameters.Add("@medicineStrength", objAddOPDTreatmentMedicineBO.medicineStrength);
        cmd.Parameters.Add("@medicineTypeId", objAddOPDTreatmentMedicineBO.medicineTypeId);
        cmd.Parameters.Add("@numberOfRefills", objAddOPDTreatmentMedicineBO.numberOfRefills);
        cmd.Parameters.Add("@quantityOnRefills", objAddOPDTreatmentMedicineBO.quantityOnRefills);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}