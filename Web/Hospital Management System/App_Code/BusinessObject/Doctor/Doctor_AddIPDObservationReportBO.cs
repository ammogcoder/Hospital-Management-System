using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationReportBO
/// </summary>
public class Doctor_AddIPDObservationReportBO
{
    public int ipdObservationReportId { get; set; }
    public string ipdObservationId { get; set; }
    public string problem { get; set; }
    public string problemDetails { get; set; }
    public string systemReview { get; set; }
    public string assessment { get; set; }
    public string plan { get; set; }
}