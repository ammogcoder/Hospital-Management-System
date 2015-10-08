using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GetDoctorNameByAppointmentTokenBL
/// </summary>
public class GetDoctorNameByAppointmentTokenBL
{
    public string GetDoctorNameByAppointmentToken(string appointmentToken)
	{
        GetDoctorNameByAppointmentTokenDL objGetDoctorNameByAppointmentTokenDL = new GetDoctorNameByAppointmentTokenDL();
        return objGetDoctorNameByAppointmentTokenDL.GetDoctorNameByAppointmentToken(appointmentToken);
	}
}