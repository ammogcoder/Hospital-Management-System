using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetDoctorByAppointmentDateBL
/// </summary>
public class GetDoctorByAppointmentDateBL
{
    public DataSet GetDoctorByAppointmentDate(string appointmentDate)
	{
        GetDoctorAppointmentsByDateDL objGetDoctorAppointmentsByDateDL = new GetDoctorAppointmentsByDateDL();
        return objGetDoctorAppointmentsByDateDL.GetDoctorAppointmentsByDate(appointmentDate);
	}
}