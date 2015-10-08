using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterPatientBL
/// </summary>
public class RegisterPatientBL
{
    public int RegisterPatient(string patientFirstName, string patientMiddleName,
            string patientLastName, string patientDOB, string patientGender, 
            string patientMaritalStatus, string patientFatherName, string patientPrimaryAddress, 
            string patientSecondaryAddress, string patientPrimaryPhone, 
            string patientSecondaryPhone, string patientEmail, string patientEmergencyContactName,
            string patientEmergencyContactNumber, int patientOccupationType, 
            string patientOccupationName, string patientOccupationAddress, string patientMonthlyIncome,
            int patientReference, int patientReferenceSourceId, string patientPrimaryLanguage,
            string patientFamilySize, int patientRegisteredById)
	{
        RegisterPatientBO objRegisterPatientBO = new RegisterPatientBO();
        objRegisterPatientBO.patientFirstName = patientFirstName;
        objRegisterPatientBO.patientMiddleName = patientMiddleName;
        objRegisterPatientBO.patientLastName = patientLastName;
        objRegisterPatientBO.patientGender = patientGender;
        objRegisterPatientBO.patientDOB = patientDOB;
        objRegisterPatientBO.patientMaritalStatus = patientMaritalStatus;
        objRegisterPatientBO.patientFatherName = patientFatherName;
        objRegisterPatientBO.patientPrimaryAddress = patientPrimaryAddress;
        objRegisterPatientBO.patientSecondaryAddress = patientSecondaryAddress;
        objRegisterPatientBO.patientPrimaryPhone = patientPrimaryPhone;
        objRegisterPatientBO.patientSecondaryPhone = patientSecondaryPhone;
        objRegisterPatientBO.patientEmail = patientEmail;
        objRegisterPatientBO.patientEmergencyContactName = patientEmergencyContactName;
        objRegisterPatientBO.patientEmergencyContactNumber = patientEmergencyContactNumber;
        objRegisterPatientBO.patientOccupationType = patientOccupationType;
        objRegisterPatientBO.patientOccupationName = patientOccupationName;
        objRegisterPatientBO.patientOccupationAddress = patientOccupationAddress;
        objRegisterPatientBO.patientMonthlyIncome = patientMonthlyIncome;
        objRegisterPatientBO.patientReference = patientReference;
        objRegisterPatientBO.patientReferenceSourceId = patientReferenceSourceId;
        objRegisterPatientBO.patientPrimaryLanguage = patientPrimaryLanguage;
        objRegisterPatientBO.patientFamilySize = patientFamilySize;
        objRegisterPatientBO.patientRegisteredById = patientRegisteredById;

        RegisterPatientDL objRegisterPatientDL = new RegisterPatientDL();
        return objRegisterPatientDL.RegisterPatient(objRegisterPatientBO);
	}
}