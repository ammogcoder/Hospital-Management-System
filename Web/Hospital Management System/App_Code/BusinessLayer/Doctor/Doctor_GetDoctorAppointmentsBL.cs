using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetDoctorAppointmentsBL
/// </summary>
public class Doctor_GetDoctorAppointmentsBL
{
	public DataSet Doctor_GetDoctorAppointments(int empId)
	{
        Doctor_GetDoctorAppointmentsDL objGetDoctorAppointmentsDL = new Doctor_GetDoctorAppointmentsDL();
        return objGetDoctorAppointmentsDL.Doctor_GetDoctorAppointments(empId);
	}
}