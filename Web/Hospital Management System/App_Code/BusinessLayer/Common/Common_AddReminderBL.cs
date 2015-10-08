using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddReminderBL
/// </summary>
public class Common_AddReminderBL
{
    public void Common_AddReminder(int empId, string reminderTitle, string reminderDetails, string reminderDate)
	{
        AddReminderBO objAddReminderBO = new AddReminderBO();
        objAddReminderBO.empId = empId;
        objAddReminderBO.reminderTitle = reminderTitle;
        objAddReminderBO.reminderDetails = reminderDetails;
        objAddReminderBO.reminderDate = reminderDate;

        AddReminderDL objAddReminderDL = new AddReminderDL();
        objAddReminderDL.AddReminder(objAddReminderBO);
	}
}