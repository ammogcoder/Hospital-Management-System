using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetAppointmentDetailsBL
/// </summary>
public class Mobile_GetAppointmentDetailsBL
{
    public DataSet Mobile_GetAppointmentDetails(string appointmentToken)
	{
        Mobile_GetAppointmentDetailsDL objMobile_GetAppointmentDetailsDL = new Mobile_GetAppointmentDetailsDL();
        return objMobile_GetAppointmentDetailsDL.Mobile_GetAppointmentDetails(appointmentToken);
	}
}