using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPatientAppointmentHistoryBL
/// </summary>
public class GetPatientAppointmentHistoryBL
{
	public DataSet GetPatientAppointmentHistory(int patientId)
	{
        GetPatientAppointmentHistoryDL objGetPatientAppointmentHistoryDL = new GetPatientAppointmentHistoryDL();
        return objGetPatientAppointmentHistoryDL.GetPatientAppointmentHistory(patientId);
	}
}