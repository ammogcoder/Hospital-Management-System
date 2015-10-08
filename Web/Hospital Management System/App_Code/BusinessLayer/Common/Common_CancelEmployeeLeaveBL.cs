using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common_CancelEmployeeLeaveBL
/// </summary>
public class Common_CancelEmployeeLeaveBL
{
    public void Common_CancelEmployeeLeave(int empId, int leaveId)
	{
        Common_CancelEmployeeLeaveDL objCommon_CancelEmployeeLeaveDL = new Common_CancelEmployeeLeaveDL();
        objCommon_CancelEmployeeLeaveDL.Common_CancelEmployeeLeave(empId, leaveId);
	}
}