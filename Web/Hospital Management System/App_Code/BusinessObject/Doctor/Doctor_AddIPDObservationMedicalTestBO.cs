using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationMedicalTestBO
/// </summary>
public class Doctor_AddIPDObservationMedicalTestBO
{
    public string ipdObservationId { get; set; }
    public int ipdObservationReportId { get; set; }
    public int medicalTestId { get; set; }
    public string medicalTestDate { get; set; }
    public string medicalTestTime { get; set; }
    public string remarks { get; set; }
}