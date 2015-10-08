using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EditAppointmentBL
/// </summary>
public class EditAppointmentBL
{
	public void EditAppointment(string appointmentToken, string oldAppointmentDate,
        string newAppointmentDate, string newAppointmentTime)
	{
        EditAppointmentBO objEditAppointmentBO = new EditAppointmentBO();
        objEditAppointmentBO.appointmentToken = appointmentToken;
        objEditAppointmentBO.oldAppointmentDate = oldAppointmentDate;
        objEditAppointmentBO.newAppointmentDate = newAppointmentDate;
        objEditAppointmentBO.newAppointmentTime = newAppointmentTime;

        EditAppointmentDL objEditAppointmentDL = new EditAppointmentDL();
        objEditAppointmentDL.EditAppointment(objEditAppointmentBO);
	}
}