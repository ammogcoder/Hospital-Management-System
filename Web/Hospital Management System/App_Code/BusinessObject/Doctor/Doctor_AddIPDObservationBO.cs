using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationBO
/// </summary>
public class Doctor_AddIPDObservationBO
{
    public string ipdObservationId { get; set; }
    public int doctorId { get; set; }
    public int patientId { get; set; }
    public string observationId { get; set; }
    public string observationDate { get; set; }
    public string observationTime { get; set; }
    public int patientHealthCondition { get; set; }
    public int transferToDoctorId { get; set; }
    public int wardTransferId { get; set; }
}