using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DeleteReminderBL
/// </summary>
public class Common_DeleteReminderBL
{
    public void Common_DeleteReminder(int reminderId)
	{
        Common_DeleteReminderDL objCommon_DeleteReminderDL = new Common_DeleteReminderDL();
        objCommon_DeleteReminderDL.Common_DeleteReminder(reminderId);
	}
}