using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterRemindersByOnDateBL
/// </summary>
public class Common_FilterRemindersByOnDateBL
{
    public DataSet Common_FilterRemindersByOnDate(string reminderDate, int empId)
	{
        FilterRemindersByOnDateDL objFilterRemindersByOnDateDL = new FilterRemindersByOnDateDL();
        return objFilterRemindersByOnDateDL.FilterRemindersByOnDate(reminderDate, empId);
	}
}