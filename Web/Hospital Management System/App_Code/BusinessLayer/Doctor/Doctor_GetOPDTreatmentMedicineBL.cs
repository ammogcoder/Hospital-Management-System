using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetOPDTreatmentMedicineBL
/// </summary>
public class Doctor_GetOPDTreatmentMedicineBL
{
    public DataSet Doctor_GetOPDTreatmentMedicine(string appointmentToken)
	{
        Doctor_GetOPDTreatmentMedicineDL objGetOPDTreatmentMedicineDL = new Doctor_GetOPDTreatmentMedicineDL();
        return objGetOPDTreatmentMedicineDL.Doctor_GetOPDTreatmentMedicine(appointmentToken);
	}
}