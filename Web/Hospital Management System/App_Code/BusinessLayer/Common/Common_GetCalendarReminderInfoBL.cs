using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetCalendarReminderInfoBL
/// </summary>
public class Common_GetCalendarReminderInfoBL
{
	public DataSet Common_GetCalendarReminderInfo(string reminderDate, int empId)
	{
        GetCalendarReminderInfoDL objGetCalendarReminderInfoDL = new GetCalendarReminderInfoDL();
        return objGetCalendarReminderInfoDL.GetCalendarReminderInfo(reminderDate, empId);
	}
}