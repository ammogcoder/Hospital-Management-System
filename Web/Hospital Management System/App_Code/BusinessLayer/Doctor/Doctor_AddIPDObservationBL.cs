using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_AddIPDObservationBL
/// </summary>
public class Doctor_AddIPDObservationBL
{
	public int Doctor_AddIPDObservation(string ipdObservationId, int doctorId, int patientId, string observationDate,
        string observationTime, int patientHealthCondition, int transferToDoctorId, int wardTransferId)
	{
        Doctor_AddIPDObservationBO objDoctor_AddIPDObservationBO = new Doctor_AddIPDObservationBO();
        objDoctor_AddIPDObservationBO.ipdObservationId = ipdObservationId;
        objDoctor_AddIPDObservationBO.doctorId = doctorId;
        objDoctor_AddIPDObservationBO.patientId = patientId;
        objDoctor_AddIPDObservationBO.observationDate = observationDate;
        objDoctor_AddIPDObservationBO.observationTime = observationTime;
        objDoctor_AddIPDObservationBO.patientHealthCondition = patientHealthCondition;
        objDoctor_AddIPDObservationBO.transferToDoctorId = transferToDoctorId;
        objDoctor_AddIPDObservationBO.wardTransferId = wardTransferId;

        Doctor_AddIPDObservationDL objDoctor_AddIPDObservationDL = new Doctor_AddIPDObservationDL();
        return objDoctor_AddIPDObservationDL.Doctor_AddIPDObservation(objDoctor_AddIPDObservationBO);
	}
}