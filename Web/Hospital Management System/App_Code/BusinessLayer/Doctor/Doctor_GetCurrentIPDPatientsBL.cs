using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetCurrentIPDPatientsBL
/// </summary>
public class Doctor_GetCurrentIPDPatientsBL
{
    public DataSet Doctor_GetCurrentIPDPatients(int doctorId)
	{
        Doctor_GetCurrentIPDPatientsDL objDoctor_GetCurrentIPDPatientsDL = new Doctor_GetCurrentIPDPatientsDL();
        return objDoctor_GetCurrentIPDPatientsDL.Doctor_GetCurrentIPDPatients(doctorId);
	}
}