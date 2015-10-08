using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_SearchIPDPatientBL
/// </summary>
public class Doctor_SearchIPDPatientBL
{
    public DataSet Doctor_SearchIPDPatient(string patientName, int doctorId)
	{
        Doctor_SearchIPDPatientDL objDoctor_SearchIPDPatientDL = new Doctor_SearchIPDPatientDL();
        return objDoctor_SearchIPDPatientDL.Doctor_SearchIPDPatient(patientName, doctorId);
	}
}