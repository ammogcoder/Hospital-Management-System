using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddOPDTreatmentMedicineBL
/// </summary>
public class Doctor_AddOPDTreatmentMedicineBL
{
	public void Doctor_AddOPDTreatmentMedicine(string appointmentToken, int medicineTypeId, int medicineNameId,
        string medicineStrength, string medicineQuantity, string medicineStartDate, int numberOfRefills,
        string quantityOnRefills, string medicineInstructions)
	{
        Doctor_AddOPDTreatmentMedicineBO objAddOPDTreatmentMedicineBO = new Doctor_AddOPDTreatmentMedicineBO();
        objAddOPDTreatmentMedicineBO.appointmentToken = appointmentToken;
        objAddOPDTreatmentMedicineBO.medicineInstructions = medicineInstructions;
        objAddOPDTreatmentMedicineBO.medicineNameId = medicineNameId;
        objAddOPDTreatmentMedicineBO.medicineQuantity = medicineQuantity;
        objAddOPDTreatmentMedicineBO.medicineStartDate = medicineStartDate;
        objAddOPDTreatmentMedicineBO.medicineStrength = medicineStrength;
        objAddOPDTreatmentMedicineBO.medicineTypeId = medicineTypeId;
        objAddOPDTreatmentMedicineBO.numberOfRefills = numberOfRefills;
        objAddOPDTreatmentMedicineBO.quantityOnRefills = quantityOnRefills;

        AddOPDTreatmentMedicineDL objAddOPDTreatmentMedicineDL = new AddOPDTreatmentMedicineDL();
        objAddOPDTreatmentMedicineDL.AddOPDTreatmentMedicine(objAddOPDTreatmentMedicineBO);
	}
}