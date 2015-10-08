using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_RegisterPatientBL
/// </summary>
public class Mobile_RegisterPatientBL
{
    public int Mobile_RegisterPatient(string patientName, string patientGender, string patientDOB, string patientPhone, string patientAddress, int patientRegisteredById)
	{
        RegisterPatientBO objRegisterPatientBO = new RegisterPatientBO();
        objRegisterPatientBO.patientFirstName = patientName;
        objRegisterPatientBO.patientGender = patientGender;
        objRegisterPatientBO.patientDOB = patientDOB;
        objRegisterPatientBO.patientPrimaryPhone = patientPhone;
        objRegisterPatientBO.patientPrimaryAddress = patientAddress;
        objRegisterPatientBO.patientRegisteredById = patientRegisteredById;

        RegisterPatientDL objRegisterPatientDL = new RegisterPatientDL();
        return objRegisterPatientDL.RegisterPatient(objRegisterPatientBO);
	}
}