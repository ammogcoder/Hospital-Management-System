using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDPatientDetailsBL
/// </summary>
public class Doctor_GetIPDPatientDetailsBL
{
    public DataSet Doctor_GetIPDPatientDetails(int patientId, int doctorId)
	{
        Doctor_GetIPDPatientDetailsDL objDoctor_GetIPDPatientDetailsDL = new Doctor_GetIPDPatientDetailsDL();
        return objDoctor_GetIPDPatientDetailsDL.Doctor_GetIPDPatientDetails(patientId, doctorId);
	}
}