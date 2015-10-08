using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_RequestPasswordValidatePatientBL
/// </summary>
public class Mobile_RequestPasswordValidatePatientBL
{
    public int Mobile_RequestPasswordValidatePatient(string patientPhone, string patientDOB)
	{
        Mobile_RequestPasswordValidatePatientDL objMobile_RequestPasswordValidatePatientDL = new Mobile_RequestPasswordValidatePatientDL();
        return objMobile_RequestPasswordValidatePatientDL.Mobile_RequestPasswordValidatePatient(patientPhone, patientDOB);
	}
}