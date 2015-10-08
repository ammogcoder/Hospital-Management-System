using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetUpcomingAppointmentsBL
/// </summary>
public class Mobile_GetUpcomingAppointmentsBL
{
    public DataSet Mobile_GetUpcomingAppointments(int patientId)
	{
        Mobile_GetUpcomingAppointmentsDL objMobile_GetUpcomingAppointmentsDL = new Mobile_GetUpcomingAppointmentsDL();
        return objMobile_GetUpcomingAppointmentsDL.Mobile_GetUpcomingAppointments(patientId);
	}
}