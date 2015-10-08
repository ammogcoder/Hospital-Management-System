using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetNewIPDPatientsBL
/// </summary>
public class Doctor_GetNewIPDPatientsBL
{
    public DataSet Doctor_GetNewIPDPatients(int doctorId)
	{
        Doctor_GetNewIPDPatientsDL objDoctor_GetNewIPDPatientsDL = new Doctor_GetNewIPDPatientsDL();
        return objDoctor_GetNewIPDPatientsDL.Doctor_GetNewIPDPatients(doctorId);
	}
}