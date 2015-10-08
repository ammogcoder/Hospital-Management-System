using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for GetPatientAppointmentsBL
/// </summary>
public class GetPatientAppointmentsBL
{
	public DataSet GetPatientAppointments(string appointmentToken)
	{
        GetPatientAppointmentsDL objGetPatientAppointmentsDL = new GetPatientAppointmentsDL();
        return objGetPatientAppointmentsDL.GetPatientAppointments(appointmentToken);
	}
}