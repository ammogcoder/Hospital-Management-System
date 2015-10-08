using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPatientAppointmentBL
/// </summary>
public class AddPatientAppointmentBL
{
    public string AddPatientAppointment(int patientId, int doctorId, string appointmentDate, string appointmentTime, int problemBodyPartId, string problemDescription)
	{
        AddPatientAppointmentBO objAddPatientAppointmentBO = new AddPatientAppointmentBO();
        
        objAddPatientAppointmentBO.patientId = patientId;
        objAddPatientAppointmentBO.doctorId = doctorId;
        objAddPatientAppointmentBO.appointmentDate = appointmentDate;
        objAddPatientAppointmentBO.appointmentTime = appointmentTime;
        objAddPatientAppointmentBO.problemBodyPartId = problemBodyPartId;
        objAddPatientAppointmentBO.problemDescription = problemDescription;

        AddPatientAppointmentDL objAddNewPatientAppointmentDL = new AddPatientAppointmentDL();
        return objAddNewPatientAppointmentDL.AddPatientAppointment(objAddPatientAppointmentBO);
	}
}