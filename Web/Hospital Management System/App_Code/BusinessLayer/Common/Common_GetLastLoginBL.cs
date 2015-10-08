using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common_GetLastLoginBL
/// </summary>
public class Common_GetLastLoginBL
{
	public string Common_GetLastLogin(int empId)
	{
        Common_GetLastLoginDL objCommon_GetLastLoginDL = new Common_GetLastLoginDL();
        return objCommon_GetLastLoginDL.Common_GetLastLogin(empId);
	}
}