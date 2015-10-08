using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddOPDTreatmentBL
/// </summary>
public class Doctor_AddOPDTreatmentBL
{
	public void Doctor_AddOPDTreatment(string appointmentToken, string treatmentDiagnosis)
    {
        Doctor_AddOPDTreatmentBO objAddOPDTreatmentBO = new Doctor_AddOPDTreatmentBO();
        objAddOPDTreatmentBO.appointmentToken = appointmentToken;
        objAddOPDTreatmentBO.treatmentDiagnosis = treatmentDiagnosis;

        AddOPDTreatmentDL objAddOPDTreatmentDL = new AddOPDTreatmentDL();
        objAddOPDTreatmentDL.AddOPDTreatment(objAddOPDTreatmentBO);
	}
}