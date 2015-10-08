using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_IPDDoctorTransferBO
/// </summary>
public class Doctor_IPDDoctorTransferBO
{
    public string transferDate { get; set; }
    public string transferTime { get; set; }
    public string reasonForTransfer { get; set; }
    public int transferToDoctorId { get; set; }
    public int transferByDoctorId { get; set; }
    public int patientId { get; set; }

}