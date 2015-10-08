using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_GetUpcomingMedicalTestsCountBL
/// </summary>
public class Mobile_GetUpcomingMedicalTestsCountBL
{
    public string Mobile_GetUpcomingMedicalTestsCount(int patientId)
	{
        Mobile_GetUpcomingMedicalTestsCountDL objMobile_GetMedicalTestsCountDL = new Mobile_GetUpcomingMedicalTestsCountDL();
        return objMobile_GetMedicalTestsCountDL.Mobile_GetUpcomingMedicalTestsCount(patientId);
	}
}