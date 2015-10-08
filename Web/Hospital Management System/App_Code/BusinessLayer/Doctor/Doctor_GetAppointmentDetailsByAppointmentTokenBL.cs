using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetAppointmentDetailsByAppointmentTokenBL
/// </summary>
public class Doctor_GetAppointmentDetailsByAppointmentTokenBL
{
	public DataSet Doctor_GetAppointmentDetailsByAppointmentToken(string appointmentToken)
	{
        Doctor_GetAppointmentDetailsByAppointmentTokenDL objDoctor_GetAppointmentDetailsByAppointmentTokenDL = new Doctor_GetAppointmentDetailsByAppointmentTokenDL();
        return objDoctor_GetAppointmentDetailsByAppointmentTokenDL.Doctor_GetAppointmentDetailsByAppointmentToken(appointmentToken);
	}
}