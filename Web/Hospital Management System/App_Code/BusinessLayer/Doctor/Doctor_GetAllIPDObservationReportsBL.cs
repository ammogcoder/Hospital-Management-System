using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetAllIPDObservationReportsBL
/// </summary>
public class Doctor_GetAllIPDObservationReportsBL
{
    public DataSet Doctor_GetAllIPDObservationReports(int patientId)
	{
        Doctor_GetAllIPDObservationReportsDL objDoctor_GetAllIPDObservationReportsDL = new Doctor_GetAllIPDObservationReportsDL();
        return objDoctor_GetAllIPDObservationReportsDL.Doctor_GetAllIPDObservationReports(patientId);
	}
}