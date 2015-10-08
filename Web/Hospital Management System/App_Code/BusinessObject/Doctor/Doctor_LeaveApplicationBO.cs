using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_LeaveApplicationBO
/// </summary>
public class Doctor_LeaveApplicationBO
{
    public int doctorId { get; set; }
    public string leaveFromDate { get; set; }
    public string leaveFromTime { get; set; }
    public string leaveToDate { get; set; }
    public string leaveToTime { get; set; }
    public string leaveReason { get; set; }
}