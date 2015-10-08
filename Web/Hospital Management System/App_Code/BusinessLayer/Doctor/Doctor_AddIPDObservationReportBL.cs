using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationReportBL
/// </summary>
public class Doctor_AddIPDObservationReportBL
{
	public int Doctor_AddIPDObservationReport(int ipdObservationReportId, string ipdObservationId, string problem, 
        string problemDetails, string systemReview, string assessment, string plan)
	{
        Doctor_AddIPDObservationReportBO objDoctor_AddIPDObservationReportBO = new Doctor_AddIPDObservationReportBO();
        objDoctor_AddIPDObservationReportBO.ipdObservationReportId = ipdObservationReportId;
        objDoctor_AddIPDObservationReportBO.ipdObservationId = ipdObservationId;
        objDoctor_AddIPDObservationReportBO.problem = problem;
        objDoctor_AddIPDObservationReportBO.problemDetails = problemDetails;
        objDoctor_AddIPDObservationReportBO.systemReview = systemReview;
        objDoctor_AddIPDObservationReportBO.assessment = assessment;
        objDoctor_AddIPDObservationReportBO.plan = plan;

        Doctor_AddIPDObservationReportDL objDoctor_AddIPDObservationReportDL = new Doctor_AddIPDObservationReportDL();
        return objDoctor_AddIPDObservationReportDL.Doctor_AddIPDObservationReport(objDoctor_AddIPDObservationReportBO);
	}
}