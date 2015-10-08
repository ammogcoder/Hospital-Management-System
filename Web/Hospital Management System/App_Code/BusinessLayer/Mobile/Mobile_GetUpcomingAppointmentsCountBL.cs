using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_GetUpcomingAppointmentsCountBL
/// </summary>
public class Mobile_GetUpcomingAppointmentsCountBL
{
	public string Mobile_GetUpcomingAppointmentsCount(string patientId)
	{
        Mobile_GetUpcomingAppointmentsCountDL objMobile_GetUpcomingAppointmentsCountDL = new Mobile_GetUpcomingAppointmentsCountDL();
        return objMobile_GetUpcomingAppointmentsCountDL.Mobile_GetUpcomingAppointmentsCount(patientId);
	}
}