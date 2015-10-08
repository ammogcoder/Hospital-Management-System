using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDActiveMedicinesBL
/// </summary>
public class Doctor_GetIPDActiveMedicinesBL
{
	public DataSet Doctor_GetIPDActiveMedicines(int patientId, int doctorId)
	{
        Doctor_GetIPDActiveMedicinesDL objDoctor_GetIPDActiveMedicinesDL = new Doctor_GetIPDActiveMedicinesDL();
        return objDoctor_GetIPDActiveMedicinesDL.Doctor_GetIPDActiveMedicines(patientId, doctorId);
	}
}