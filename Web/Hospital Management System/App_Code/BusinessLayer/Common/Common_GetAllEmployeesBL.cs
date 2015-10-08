using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetAllEmployeesBL
/// </summary>
public class Common_GetAllEmployeesBL
{
	public DataSet Common_GetAllEmployees(int empId)
	{
        GetAllEmployeesDL objGetAllEmployeesDL = new GetAllEmployeesDL();
        return objGetAllEmployeesDL.GetAllEmployees(empId);
	}
}