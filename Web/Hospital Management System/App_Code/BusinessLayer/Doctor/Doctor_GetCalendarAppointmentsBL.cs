using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetCalendarAppointmentsBL
/// </summary>
public class Doctor_GetCalendarAppointmentsBL
{
	public DataSet Doctor_GetCalendarAppointments(int doctorId)
	{
        Doctor_GetCalendarAppointmentsDL objDoctor_GetCalendarAppointmentsDL = new Doctor_GetCalendarAppointmentsDL();
        return objDoctor_GetCalendarAppointmentsDL.Doctor_GetCalendarAppointments(doctorId);
	}
}