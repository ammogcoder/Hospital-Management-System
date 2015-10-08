using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetReminderBL
/// </summary>
public class Common_GetReminderBL
{
	public DataSet Common_GetReminder(int empId)
	{
        GetReminderDL objGetReminderDL = new GetReminderDL();
        return objGetReminderDL.GetReminder(empId);
	}
}