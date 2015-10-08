using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetDoctorAppointmentsByDateBL
/// </summary>
public class GetDoctorAppointmentsByDateBL
{
	public DataSet GetDoctorAppointmentsByDate(string appointmentDate)
	{
        GetDoctorAppointmentsByDateDL objGetDoctorAppointmentsByDateDL = new GetDoctorAppointmentsByDateDL();
        return objGetDoctorAppointmentsByDateDL.GetDoctorAppointmentsByDate(appointmentDate);
	}
}