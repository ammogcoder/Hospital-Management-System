using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationMedicalTestBL
/// </summary>
public class Doctor_GetIPDObservationMedicalTestBL
{
	public DataSet Doctor_GetIPDObservationMedicalTest(string ipdObservationId)
	{
        Doctor_GetIPDObservationMedicalTestDL objDoctor_GetIPDObservationMedicalTestDL = new Doctor_GetIPDObservationMedicalTestDL();
        return objDoctor_GetIPDObservationMedicalTestDL.Doctor_GetIPDObservationMedicalTest(ipdObservationId);
	}
}