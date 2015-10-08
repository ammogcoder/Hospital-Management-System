using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddCaseBO
/// </summary>
public class AddCaseBO
{
    public int doctorId { get; set; }
    public int patientId { get; set; }
    public string caseStartDate { get; set; }
    public string caseEndDate { get; set; }
}