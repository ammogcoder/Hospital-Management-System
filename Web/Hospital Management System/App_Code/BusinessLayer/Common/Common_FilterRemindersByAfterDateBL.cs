using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterRemindersByAfterDateBL
/// </summary>
public class Common_FilterRemindersByAfterDateBL
{
    public DataSet Common_FilterRemindersByAfterDate(string reminderDate, int empId)
	{
        FilterRemindersByAfterDateDL objFilterRemindersByAfterDateDL = new FilterRemindersByAfterDateDL();
        return objFilterRemindersByAfterDateDL.FilterRemindersByAfterDate(reminderDate, empId);
	}
}