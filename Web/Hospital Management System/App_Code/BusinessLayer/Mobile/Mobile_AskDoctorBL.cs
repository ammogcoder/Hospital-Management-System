using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_AskDoctorBL
/// </summary>
public class Mobile_AskDoctorBL
{
    public void Mobile_AskDoctor(int patientId, int doctorId, string problem, string problemDetails)
	{
        Mobile_AskDoctorBO objMobile_AskDoctorBO = new Mobile_AskDoctorBO();
        objMobile_AskDoctorBO.patientId = patientId;
        objMobile_AskDoctorBO.doctorId = doctorId;
        objMobile_AskDoctorBO.problem = problem;
        objMobile_AskDoctorBO.problemDetails = problemDetails;

        Mobile_AskDoctorDL objMobile_AskDoctorDL = new Mobile_AskDoctorDL();
        objMobile_AskDoctorDL.Mobile_AskDoctor(objMobile_AskDoctorBO);
	}
}