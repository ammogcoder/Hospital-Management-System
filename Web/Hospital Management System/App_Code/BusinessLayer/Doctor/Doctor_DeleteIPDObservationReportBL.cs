using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_DeleteIPDObservationReportBL
/// </summary>
public class Doctor_DeleteIPDObservationReportBL
{
    public void Doctor_DeleteIPDObservationReport(int ipdObservationReportId)
	{
        Doctor_DeleteIPDObservationReportDL objDoctor_DeleteIPDObservationReportDL = new Doctor_DeleteIPDObservationReportDL();
        objDoctor_DeleteIPDObservationReportDL.Doctor_DeleteIPDObservationReport(ipdObservationReportId);
	}
}