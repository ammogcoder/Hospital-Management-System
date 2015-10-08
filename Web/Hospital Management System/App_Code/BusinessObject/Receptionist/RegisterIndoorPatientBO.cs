using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterIndoorPatientBO
/// </summary>
public class RegisterIndoorPatientBO
{
    public int patientId { get; set; }
    public int patientGeneralHealth { get; set; }
    public string patientRegularMedications { get; set; }
    public int patientAllergyStatus { get; set; }
    public string patientAllergies { get; set; }
    public int patientPastSurgeryStatus { get; set; }
    public string patientSurgery1 { get; set; }
    public string patientSurgery1Date { get; set; }
    public string patientSurgery2 { get; set; }
    public string patientSurgery2Date { get; set; }
    public string patientSurgery3 { get; set; }
    public string patientSurgery3Date { get; set; }
    public int patientMedicalInsuranceStatus { get; set; }
    public string patientMedicalInsuranceProvider { get; set; }
    public string patientMedicalInsurancePolicyNumber { get; set; }
    public string patientHeight { get; set; }
    public string patientWeight { get; set; }
    public string patientBloodGroup { get; set; }
    public int patientAttendingDoctor { get; set; }
    public string patientDateOfAdmit { get; set; }
    public string patientTimeOfAdmit { get; set; }
    public string patientRemark { get; set; }
}