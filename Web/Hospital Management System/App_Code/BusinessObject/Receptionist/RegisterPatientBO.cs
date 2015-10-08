using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterPatient
/// </summary>
public class RegisterPatientBO
{
    public string patientFirstName { get; set; }
    public string patientMiddleName { get; set; }
    public string patientLastName { get; set; }
    public string patientDOB { get; set; } 
    public string patientGender { get; set; } 
    public string patientMaritalStatus { get; set; } 
    public string patientFatherName { get; set; } 
    public string patientPrimaryAddress { get; set; }
    public string patientSecondaryAddress { get; set; }
    public string patientPrimaryPhone { get; set; } 
    public string patientSecondaryPhone { get; set; } 
    public string patientEmail { get; set; }
    public string patientEmergencyContactName { get; set; }
    public string patientEmergencyContactNumber { get; set; } 
    public int patientOccupationType { get; set; } 
    public string patientOccupationName { get; set; } 
    public string patientOccupationAddress { get; set; } 
    public string patientMonthlyIncome { get; set; } 
    public int patientReference { get; set; } 
    public int patientReferenceSourceId { get; set; } 
    public string patientPrimaryLanguage { get; set; }
    public string patientFamilySize { get; set; }
    public int patientRegisteredById { get; set; }
}