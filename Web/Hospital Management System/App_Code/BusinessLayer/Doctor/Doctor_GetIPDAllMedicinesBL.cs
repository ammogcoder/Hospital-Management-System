using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDAllMedicinesBL
/// </summary>
public class Doctor_GetIPDAllMedicinesBL
{
    public DataSet Doctor_GetIPDAllMedicines(int patientId, int doctorId)
	{
        Doctor_GetIPDAllMedicinesDL objDoctor_GetIPDAllMedicinesDL = new Doctor_GetIPDAllMedicinesDL();
        return objDoctor_GetIPDAllMedicinesDL.Doctor_GetIPDAllMedicines(patientId, doctorId);
	}
}