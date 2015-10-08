using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterIndoorPatientBL
/// </summary>
public class RegisterIndoorPatientBL
{
	 public int RegisterIndoorPatient(int patientId ,int patientGeneralHealth ,
         string patientRegularMedications, int patientAllergyStatus, string patientAllergies,
         int patientPastSurgeryStatus, string patientSurgery1, string patientSurgery1Date,
         string patientSurgery2,string patientSurgery2Date, string patientSurgery3,
         string patientSurgery3Date, int patientMedicalInsuranceStatus, 
         string patientMedicalInsuranceProvider, string patientMedicalInsurancePolicyNumber, 
         string patientHeight, string patientBloodGroup, string patientWeight, 
         int patientAttendingDoctor, string patientDateOfAdmit, string patientTimeOfAdmit, 
         string patientRemark)
	{
        RegisterIndoorPatientBO objRegisterIndoorPatientBO = new RegisterIndoorPatientBO();
        objRegisterIndoorPatientBO.patientId = patientId;
        objRegisterIndoorPatientBO.patientGeneralHealth = patientGeneralHealth;
        objRegisterIndoorPatientBO.patientRegularMedications = patientRegularMedications;
        objRegisterIndoorPatientBO.patientAllergyStatus = patientAllergyStatus;
        objRegisterIndoorPatientBO.patientAllergies = patientAllergies;
        objRegisterIndoorPatientBO.patientPastSurgeryStatus = patientPastSurgeryStatus;
        objRegisterIndoorPatientBO.patientSurgery1 = patientSurgery1;
        objRegisterIndoorPatientBO.patientSurgery1Date = patientSurgery1Date;
        objRegisterIndoorPatientBO.patientSurgery2 = patientSurgery2;
        objRegisterIndoorPatientBO.patientSurgery2Date = patientSurgery2Date;
        objRegisterIndoorPatientBO.patientSurgery3 = patientSurgery3;
        objRegisterIndoorPatientBO.patientSurgery3Date = patientSurgery3Date;
        objRegisterIndoorPatientBO.patientMedicalInsuranceStatus = patientMedicalInsuranceStatus;
        objRegisterIndoorPatientBO.patientMedicalInsuranceProvider = patientMedicalInsuranceProvider;
        objRegisterIndoorPatientBO.patientMedicalInsurancePolicyNumber = patientMedicalInsurancePolicyNumber;
        objRegisterIndoorPatientBO.patientHeight = patientHeight;
        objRegisterIndoorPatientBO.patientWeight = patientWeight;
        objRegisterIndoorPatientBO.patientBloodGroup = patientBloodGroup;
        objRegisterIndoorPatientBO.patientAttendingDoctor = patientAttendingDoctor;
        objRegisterIndoorPatientBO.patientDateOfAdmit = patientDateOfAdmit;
        objRegisterIndoorPatientBO.patientTimeOfAdmit = patientTimeOfAdmit;
        objRegisterIndoorPatientBO.patientRemark = patientRemark;

        RegisterIndoorPatientDL objRegisterIndoorPatientDL = new RegisterIndoorPatientDL();
        return objRegisterIndoorPatientDL.RegisterIndoorPatient(objRegisterIndoorPatientBO);
	}
}