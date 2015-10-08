using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPatientAppointmentBO
/// </summary>
public class AddPatientAppointmentBO
{
    public int patientId { get; set; }
    public int doctorId { get; set; }
    public string appointmentDate { get; set; }
    public string appointmentTime { get; set; }
    public int problemBodyPartId { get; set; }
    public string problemDescription { get; set; }
}