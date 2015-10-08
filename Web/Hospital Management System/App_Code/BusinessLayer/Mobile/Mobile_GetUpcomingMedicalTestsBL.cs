using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetUpcomingMedicalTestsBL
/// </summary>
public class Mobile_GetUpcomingMedicalTestsBL
{
	public DataSet Mobile_GetUpcomingMedicalTests(int patientId)
	{
        Mobile_GetUpcomingMedicalTestsDL objMobile_GetUpcomingMedicalTestsDL = new Mobile_GetUpcomingMedicalTestsDL();
        return objMobile_GetUpcomingMedicalTestsDL.Mobile_GetUpcomingMedicalTests(patientId);
	}
}