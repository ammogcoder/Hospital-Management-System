using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetAppointmentsByDateBL
/// </summary>
public class Doctor_GetAppointmentsByDateBL
{
    public DataSet Doctor_GetAppointmentsByDate(int doctorId, string appointmentDate)
	{
        Doctor_GetAppointmentsByDateDL objDoctor_GetAppointmentsByDateDL = new Doctor_GetAppointmentsByDateDL();
        return objDoctor_GetAppointmentsByDateDL.Doctor_GetAppointmentsByDate(doctorId, appointmentDate);
	}
}