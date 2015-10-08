using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetPreviousAppointmentDetailsBL
/// </summary>
public class Mobile_GetPreviousAppointmentDetailsBL
{
    public DataSet Mobile_GetPreviousAppointmentDetails(string appointmentToken)
	{
        Mobile_GetPreviousAppointmentDetailsDL objMobile_GetPreviousAppointmentDetailsDL = new Mobile_GetPreviousAppointmentDetailsDL();
        return objMobile_GetPreviousAppointmentDetailsDL.Mobile_GetPreviousAppointmentDetails(appointmentToken);
	}
}