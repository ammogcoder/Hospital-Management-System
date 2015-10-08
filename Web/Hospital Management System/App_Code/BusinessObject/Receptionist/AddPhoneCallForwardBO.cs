using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPhoneCallForwardBO
/// </summary>
public class AddPhoneCallForwardBO
{
    public int receptionistId { get; set; }
    public string phoneNo { get; set; }
    public string callDate { get; set; }
    public string callTime { get; set; }
    public string callerName { get; set; }
    public int callForwardedTo { get; set; }
}