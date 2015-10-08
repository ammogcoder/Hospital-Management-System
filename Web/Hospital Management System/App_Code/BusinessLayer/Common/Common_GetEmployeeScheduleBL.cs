using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GetEmployeeScheduleBL
/// </summary>
public class Common_GetEmployeeScheduleBL
{
	public DataSet Common_GetEmployeeSchedule(int empId)
	{
        GetEmployeeScheduleDL objGetEmployeeScheduleDL = new GetEmployeeScheduleDL();
        return objGetEmployeeScheduleDL.GetEmployeeSchedule(empId);
	}
}