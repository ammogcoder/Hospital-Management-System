using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetPreviousMedicalTestsBL
/// </summary>
public class Mobile_GetPreviousMedicalTestsBL
{
    public DataSet Mobile_GetPreviousMedicalTests(int patientId)
	{
        Mobile_GetPreviousMedicalTestsDL objMobile_GetPreviousMedicalTestsDL = new Mobile_GetPreviousMedicalTestsDL();
        return objMobile_GetPreviousMedicalTestsDL.Mobile_GetPreviousMedicalTests(patientId);
	}
}