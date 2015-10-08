using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationMedicineBL
/// </summary>
public class Doctor_AddIPDObservationMedicineBL
{
	public void Doctor_AddIPDObservationMedicine(string ipdObservationId, int ipdObservationReportId, int medicineTypeId, 
        int medicineNameId, string medicineStrength, string medicineQuantity, string medicineStartDate, 
        int numberOfRefills, string quantityOnRefills, string medicineInstructions)
	{
        Doctor_AddIPDObservationMedicineBO objDoctor_AddIPDObservationMedicineBO = new Doctor_AddIPDObservationMedicineBO();
        objDoctor_AddIPDObservationMedicineBO.ipdObservationId = ipdObservationId;
        objDoctor_AddIPDObservationMedicineBO.ipdObservationReportId = ipdObservationReportId;
        objDoctor_AddIPDObservationMedicineBO.medicineTypeId = medicineTypeId;
        objDoctor_AddIPDObservationMedicineBO.medicineNameId = medicineNameId;
        objDoctor_AddIPDObservationMedicineBO.medicineStrength = medicineStrength;
        objDoctor_AddIPDObservationMedicineBO.medicineQuantity = medicineQuantity;
        objDoctor_AddIPDObservationMedicineBO.medicineStartDate = medicineStartDate;
        objDoctor_AddIPDObservationMedicineBO.numberOfRefills = numberOfRefills;
        objDoctor_AddIPDObservationMedicineBO.quantityOnRefills = quantityOnRefills;
        objDoctor_AddIPDObservationMedicineBO.medicineInstructions = medicineInstructions;

        Doctor_AddIPDObservationMedicineDL objDoctor_AddIPDObservationMedicineDL = new Doctor_AddIPDObservationMedicineDL();
        objDoctor_AddIPDObservationMedicineDL.Doctor_AddIPDObservationMedicine(objDoctor_AddIPDObservationMedicineBO);
	}
}