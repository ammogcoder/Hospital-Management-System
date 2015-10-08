using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetCalendarDoctorAppointmentsByIdBL
/// </summary>
public class Common_GetCalendarDoctorAppointmentsByIdBL
{
	public DataSet Common_GetCalendarDoctorAppointmentsById(int doctorId)
	{
        GetCalendarDoctorAppointmentsByIdDL objGetCalendarDoctorAppointmentsByIdDL = new GetCalendarDoctorAppointmentsByIdDL();
        return objGetCalendarDoctorAppointmentsByIdDL.GetCalendarDoctorAppointmentsById(doctorId);
	}
}