using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetPreviousAppointmentsBL
/// </summary>
public class Mobile_GetPreviousAppointmentsBL
{
    public DataSet Mobile_GetPreviousAppointments(int patientId)
	{
        Mobile_GetPreviousAppointmentsDL objMobile_GetPreviousAppointmentsDL = new Mobile_GetPreviousAppointmentsDL();
        return objMobile_GetPreviousAppointmentsDL.Mobile_GetPreviousAppointments(patientId);
	}
}