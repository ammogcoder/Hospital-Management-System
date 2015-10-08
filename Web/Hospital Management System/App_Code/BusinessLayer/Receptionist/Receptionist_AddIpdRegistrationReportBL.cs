using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddIpdRegistrationReportBL
/// </summary>
public class AddIpdRegistrationReportBL
{
	public string AddIpdRegistrationReport(int empId, int ipdId)
	{
        AddIpdRegistrationReportDL objAddIpdRegistrationReportDL = new AddIpdRegistrationReportDL();
        return objAddIpdRegistrationReportDL.AddIpdRegistrationReport(empId, ipdId);
	}
}