using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDReportMedicineBL
/// </summary>
public class Doctor_GetIPDReportMedicineBL
{
    public DataSet Doctor_GetIPDReportMedicine(int ipdObservationReportId, string ipdObservationId)
	{
        Doctor_GetIPDReportMedicineDL objDoctor_GetIPDReportMedicineDL = new Doctor_GetIPDReportMedicineDL();
        return objDoctor_GetIPDReportMedicineDL.Doctor_GetIPDReportMedicine(ipdObservationReportId, ipdObservationId);
	}
}