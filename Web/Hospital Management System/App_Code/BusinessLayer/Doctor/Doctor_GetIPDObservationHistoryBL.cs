using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationHistoryBL
/// </summary>
public class Doctor_GetIPDObservationHistoryBL
{
	public DataSet Doctor_GetIPDObservationHistory(int patientId, int doctorId)
	{
        Doctor_GetIPDObservationHistoryDL objDoctor_GetIPDObservationHistoryDL = new Doctor_GetIPDObservationHistoryDL();
        return objDoctor_GetIPDObservationHistoryDL.Doctor_GetIPDObservationHistory(patientId, doctorId);
	}
}