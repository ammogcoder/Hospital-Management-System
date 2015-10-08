using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddReminderBO
/// </summary>
public class AddReminderBO
{
    public int empId { get; set; }
    public int reminderId { get; set; }
    public string reminderTitle { get; set; }
    public string reminderDetails { get; set; }
    public string reminderDate { get; set; }
}