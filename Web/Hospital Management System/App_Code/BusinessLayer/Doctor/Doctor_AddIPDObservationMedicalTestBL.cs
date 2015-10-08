using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationMedicalTestBL
/// </summary>
public class Doctor_AddIPDObservationMedicalTestBL
{
	public void Doctor_AddIPDObservationMedicalTest(string ipdObservationId, int ipdObservationReportId, int medicalTestId,
        string medicalTestDate, string medicalTestTime, string remarks)
	{
        Doctor_AddIPDObservationMedicalTestBO objDoctor_AddIPDObservationMedicalTestBO = new Doctor_AddIPDObservationMedicalTestBO();
        objDoctor_AddIPDObservationMedicalTestBO.ipdObservationId = ipdObservationId;
        objDoctor_AddIPDObservationMedicalTestBO.ipdObservationReportId = ipdObservationReportId;
        objDoctor_AddIPDObservationMedicalTestBO.medicalTestDate = medicalTestDate;
        objDoctor_AddIPDObservationMedicalTestBO.medicalTestTime = medicalTestTime;
        objDoctor_AddIPDObservationMedicalTestBO.medicalTestId = medicalTestId;
        objDoctor_AddIPDObservationMedicalTestBO.remarks = remarks;

        Doctor_AddIPDObservationMedicalTestDL objDoctor_AddIPDObservationMedicalTestDL = new Doctor_AddIPDObservationMedicalTestDL();
        objDoctor_AddIPDObservationMedicalTestDL.Doctor_AddIPDObservationMedicalTest(objDoctor_AddIPDObservationMedicalTestBO);
	}
}