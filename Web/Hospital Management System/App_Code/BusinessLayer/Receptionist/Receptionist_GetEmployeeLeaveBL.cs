using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetEmployeeLeaveBL
/// </summary>
public class GetEmployeeLeaveBL
{
	public DataSet GetEmployeeLeave(int empId)
	{
        GetEmployeeLeaveDL objGetEmployeeLeaveDL = new GetEmployeeLeaveDL();
        return objGetEmployeeLeaveDL.GetEmployeeLeave(empId);
	}
}