using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CancelAppointmentBL
/// </summary>
public class CancelAppointmentBL
{
    public void CancelAppointment(string appointmentToken)
	{
        CancelAppointmentDL objCancelAppointmentDL = new CancelAppointmentDL();
        objCancelAppointmentDL.CancelAppointment(appointmentToken);
	}
}