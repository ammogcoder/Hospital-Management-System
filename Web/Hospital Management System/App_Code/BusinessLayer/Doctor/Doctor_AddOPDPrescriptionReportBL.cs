using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddOPDPrescriptionReportBL
/// </summary>
public class Doctor_AddOPDPrescriptionReportBL
{
    public string Doctor_AddOPDPrescriptionReport(int empId, string appointmentToken)
	{
        AddOPDPrescriptionReportDL objAddOPDPrescriptionReportDL = new AddOPDPrescriptionReportDL();
        return objAddOPDPrescriptionReportDL.AddOPDPrescriptionReport(empId, appointmentToken);
	}
}