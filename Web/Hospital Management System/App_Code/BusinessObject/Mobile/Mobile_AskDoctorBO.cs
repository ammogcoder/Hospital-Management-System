using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_AskDoctorBO
/// </summary>
public class Mobile_AskDoctorBO
{
	public int patientId { get; set; }
    public int doctorId { get; set; }
    public string problem{ get; set; }
    public string problemDetails { get; set; }
}