using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetAllRemindersBL
/// </summary>
public class Common_GetAllRemindersBL
{
    public DataSet Common_GetAllReminders(int empId)
	{
        GetAllRemindersDL objGetAllRemindersDL = new GetAllRemindersDL();
        return objGetAllRemindersDL.GetAllReminders(empId);
	}
}