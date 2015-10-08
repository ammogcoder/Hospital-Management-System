using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationReportBL
/// </summary>
public class Doctor_GetIPDObservationReportBL
{
    public DataSet Doctor_GetIPDObservationReport(string ipdObservationId)
	{
        Doctor_GetIPDObservationReportDL objDoctor_GetIPDObservationReportDL = new Doctor_GetIPDObservationReportDL();
        return objDoctor_GetIPDObservationReportDL.Doctor_GetIPDObservationReport(ipdObservationId);
	}
}