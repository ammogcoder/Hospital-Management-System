using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetOPDTreatmentAllMedicinesBL
/// </summary>
public class Doctor_GetOPDTreatmentAllMedicinesBL
{
	public DataSet Doctor_GetOPDTreatmentAllMedicines(int patientId)
	{
        Doctor_GetOPDTreatmentAllMedicinesDL objGetOPDTreatmentAllMedicinesDL = new Doctor_GetOPDTreatmentAllMedicinesDL();
        return objGetOPDTreatmentAllMedicinesDL.Doctor_GetOPDTreatmentAllMedicines(patientId);
	}
}