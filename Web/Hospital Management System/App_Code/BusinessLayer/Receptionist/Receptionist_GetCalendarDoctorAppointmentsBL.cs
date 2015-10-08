using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetCalendarDoctorAppointmentsBL
/// </summary>
public class GetCalendarDoctorAppointmentsBL
{
	public DataSet GetCalendarDoctorAppointments()
	{
        GetCalendarDoctorAppointmentsDL objGetCalendarDoctorAppointmentsDL = new GetCalendarDoctorAppointmentsDL();
        return objGetCalendarDoctorAppointmentsDL.GetCalendarDoctorAppointments();
	}
}