using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GetEmployeeNameByIdBL
/// </summary>
public class Common_GetEmployeeNameByIdBL
{
    public string Common_GetEmployeeNameById(int empId)
	{
        GetEmployeeNameByIdDL objGetEmployeeNameByIdDL = new GetEmployeeNameByIdDL();
        return objGetEmployeeNameByIdDL.GetEmployeeNameById(empId);
	}
}