using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterRemindersByBeforeDateBL
/// </summary>
public class Common_FilterRemindersByBeforeDateBL
{
    public DataSet Common_FilterRemindersByBeforeDate(string reminderDate, int empId)
	{
        FilterRemindersByBeforeDateDL objFilterRemindersByBeforeDateDL = new FilterRemindersByBeforeDateDL();
        return objFilterRemindersByBeforeDateDL.FilterRemindersByBeforeDate(reminderDate, empId);
	}
}