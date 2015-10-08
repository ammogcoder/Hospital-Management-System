using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmployeeNameBL
/// </summary>
public class Common_EmployeeNameBL
{
	public string Common_EmployeeName(int empId)
	{
        EmployeeNameDL objEmployeeNameDL = new EmployeeNameDL();
        return objEmployeeNameDL.EmployeeName(empId);
	}
}