using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_DeleteIPDObservationMedicalTestBL
/// </summary>
public class Doctor_DeleteIPDObservationMedicalTestBL
{
    public void Doctor_DeleteIPDObservationMedicalTest(int ipdObservationMedicalTestId)
	{
		Doctor_DeleteIPDObservationMedicalTestDL objDoctor_DeleteIPDObservationMedicalTestDL=new Doctor_DeleteIPDObservationMedicalTestDL();
        objDoctor_DeleteIPDObservationMedicalTestDL.Doctor_DeleteIPDObservationMedicalTest(ipdObservationMedicalTestId);
	}
}