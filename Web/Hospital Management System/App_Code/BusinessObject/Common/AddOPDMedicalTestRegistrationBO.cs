using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common_AddOPDMedicalTestRegistrationBO
/// </summary>
public class Common_AddOPDMedicalTestRegistrationBO
{
    public int patientId { get; set; }
    public int medicalTestId { get; set; }
    public string testDate { get; set; }
    public string testTime { get; set; }
}