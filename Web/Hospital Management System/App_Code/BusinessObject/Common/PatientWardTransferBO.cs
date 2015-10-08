using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PatientWardTransferBO
/// </summary>
public class Common_PatientWardTransferBO
{
    public int patientId { get; set; }
    public int previousWardId { get; set; }
    public int previousWardNumber { get; set; }
    public string transferDate { get; set; }
    public string transferTime { get; set; }
    public string reasonForTransfer { get; set; }
    public int newWardId { get; set; }
    public int newWardNumber { get; set; }
    public int empId { get; set; }
}