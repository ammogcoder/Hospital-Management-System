using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetDoctorAppointmentsByIdBL
/// </summary>
public class Common_GetDoctorAppointmentsByIdBL
{
	public DataSet Common_GetDoctorAppointmentsById(int doctorId)
	{
        GetDoctorAppointmentsByIdDL objGetDoctorAppointmentsByIdDL = new GetDoctorAppointmentsByIdDL();
        return objGetDoctorAppointmentsByIdDL.GetDoctorAppointmentsById(doctorId);
	}
}