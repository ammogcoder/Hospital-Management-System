using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetDoctorAppointmentByDateTimeBL
/// </summary>
public class Common_GetDoctorAppointmentByDateTimeBL
{
	public DataSet Common_GetDoctorAppointmentByDateTime(int empId, string appointmentDate, string appointmentTime)
	{
        GetDoctorAppointmentByDateTimeDL objGetDoctorAppointmentByDateTimeDL = new GetDoctorAppointmentByDateTimeDL();
        return objGetDoctorAppointmentByDateTimeDL.GetDoctorAppointmentByDateTime(empId, appointmentDate, appointmentTime);
	}
}