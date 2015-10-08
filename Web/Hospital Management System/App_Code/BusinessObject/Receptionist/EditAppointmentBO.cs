using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EditAppointmentBO
/// </summary>
public class EditAppointmentBO
{
    public string appointmentToken { get; set; }
    public string oldAppointmentDate { get; set; }
    public string newAppointmentDate { get; set; }
    public string newAppointmentTime { get; set; }
}