using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string RequestPassword(string patientPhone, string patientDOB)
    {
        patientDOB = DateTime.ParseExact(patientDOB, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        Mobile_RequestPasswordValidatePatientBL objMobile_RequestPasswordValidatePatientBL = new Mobile_RequestPasswordValidatePatientBL();
        int patientId = objMobile_RequestPasswordValidatePatientBL.Mobile_RequestPasswordValidatePatient(patientPhone, patientDOB);
        string patientPassword = "-1";
        if(patientId > 0)
        {
            Mobile_RequestPasswordBL objMobile_RequestPasswordBL = new Mobile_RequestPasswordBL();
            patientPassword = (new Random()).Next(100000, 1000000).ToString();
            objMobile_RequestPasswordBL.Mobile_RequestPassword(patientId, patientPassword);
        }
        return patientPassword;
    }

    [WebMethod]
    public int RegisterPatient(string patientName, string patientGender, string patientDOB, string patientPhone, string patientAddress, int patientRegisteredById)
    {
        Mobile_RegisterPatientBL objMobile_RegisterPatientBL = new Mobile_RegisterPatientBL();
        return objMobile_RegisterPatientBL.Mobile_RegisterPatient(patientName, patientGender, patientDOB, patientPhone, patientAddress, patientRegisteredById);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string Login(string patientPhone, string patientPassword)
    {
        Mobile_LoginBL objMobile_LoginBL = new Mobile_LoginBL();
        return JsonConvert.SerializeObject(objMobile_LoginBL.Mobile_Login(patientPhone, patientPassword));
    }

    [WebMethod]
    public void CreateAppointment(string patientId, string doctorId, string appointmentDate, string appointmentTime, string problemBodyPartId, string problemDescription)
    {
        AddPatientAppointmentBL objAddPatientAppointmentBL = new AddPatientAppointmentBL();
        objAddPatientAppointmentBL.AddPatientAppointment(Convert.ToInt32(patientId), Convert.ToInt32(doctorId), DateTime.ParseExact(appointmentDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString(), appointmentTime, Convert.ToInt32(problemBodyPartId), problemDescription);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
    public string GetBodyParts()
    {
        Mobile_GetBodyPartsBL objMobile_GetBodyPartsBL = new Mobile_GetBodyPartsBL();
        return JsonConvert.SerializeObject(objMobile_GetBodyPartsBL.Mobile_GetBodyParts(), Formatting.Indented);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetDepartments()
    {
        Mobile_GetDepartmentsBL objMobile_GetDepartmentsBL = new Mobile_GetDepartmentsBL();
        return JsonConvert.SerializeObject(objMobile_GetDepartmentsBL.Mobile_GetDepartments(), Formatting.Indented);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetDoctorByDepartment(int departmentId)
    {
        Common_DoctorByDepartmentBL objCommon_DoctorByDepartmentBL = new Common_DoctorByDepartmentBL();
        return JsonConvert.SerializeObject(objCommon_DoctorByDepartmentBL.Common_DoctorByDepartment(departmentId), Formatting.Indented); 
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetUpcomingAppointments(int patientId)
    {
        Mobile_GetUpcomingAppointmentsBL objMobile_GetUpcomingAppointmentsBL = new Mobile_GetUpcomingAppointmentsBL();
        return JsonConvert.SerializeObject(objMobile_GetUpcomingAppointmentsBL.Mobile_GetUpcomingAppointments(patientId), Formatting.Indented);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetUpcomingAppointmentsCount(string patientId)
    {
        Mobile_GetUpcomingAppointmentsCountBL objMobile_GetUpcomingAppointmentsCountBL = new Mobile_GetUpcomingAppointmentsCountBL();
        JsonClass objJsonClass = new JsonClass();
        objJsonClass.appointmentCount = objMobile_GetUpcomingAppointmentsCountBL.Mobile_GetUpcomingAppointmentsCount(patientId);
        return JsonConvert.SerializeObject(objJsonClass, Formatting.Indented);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetPreviousAppointments(int patientId)
    {
        Mobile_GetPreviousAppointmentsBL objMobile_GetPastAppointmentsBL = new Mobile_GetPreviousAppointmentsBL();
        return JsonConvert.SerializeObject(objMobile_GetPastAppointmentsBL.Mobile_GetPreviousAppointments(patientId), Formatting.Indented);
    }

    [WebMethod]
    public void CancelAppointment(string appointmentToken)
    {
        CancelAppointmentBL objCancelAppointmentBL = new CancelAppointmentBL();
        objCancelAppointmentBL.CancelAppointment(appointmentToken);
    }

    [WebMethod]
    public void AskDoctor(int patientId, int doctorId, string problem, string problemDetails)
    {
        Mobile_AskDoctorBL objMobile_AskDoctorBL = new Mobile_AskDoctorBL();
        objMobile_AskDoctorBL.Mobile_AskDoctor(patientId, doctorId, problem, problemDetails);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetDoctorsByDepartment(int departmentId)
    {
        Common_DoctorByDepartmentBL objCommon_DoctorByDepartmentBL = new Common_DoctorByDepartmentBL();
        return JsonConvert.SerializeObject(objCommon_DoctorByDepartmentBL.Common_DoctorByDepartment(departmentId));
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetMedicalTestPackages()
    {
        Common_GetMedicalTestPackagesBL objCommon_GetMedicalTestPackagesBL = new Common_GetMedicalTestPackagesBL();
        return JsonConvert.SerializeObject(objCommon_GetMedicalTestPackagesBL.Common_GetMedicalTestPackages());
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetMedicalTestsByDisorder()
    {
        Common_GetMedicalTestsByDisorderBL objCommon_GetMedicalTestsByDisorderBL = new Common_GetMedicalTestsByDisorderBL();
        return JsonConvert.SerializeObject(objCommon_GetMedicalTestsByDisorderBL.Common_GetMedicalTestsByDisorder());
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetIndividualMedicalTests()
    {
        Common_GetIndividualMedicalTestsBL objCommon_GetIndividualMedicalTestsBL = new Common_GetIndividualMedicalTestsBL();
        return JsonConvert.SerializeObject(objCommon_GetIndividualMedicalTestsBL.Common_GetIndividualMedicalTests());
    }

    [WebMethod]
    public void MedicalTestRegistration(string patientId, string medicalTestId, string testDate, string testTime)
    {
        Common_AddOPDMedicalTestRegistrationBL objCommon_AddOPDMedicalTestRegistrationBL = new Common_AddOPDMedicalTestRegistrationBL();
        objCommon_AddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(Convert.ToInt32(patientId), Convert.ToInt32(medicalTestId), DateTime.ParseExact(testDate, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString(), testTime);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetMedicalTestPackageComponents(string medicalTestPackageId)
    {
        Common_GetMedicalTestPackageComponentsBL objCommon_GetMedicalTestPackageComponentsBL = new Common_GetMedicalTestPackageComponentsBL();
        return JsonConvert.SerializeObject(objCommon_GetMedicalTestPackageComponentsBL.Common_GetMedicalTestPackageComponents(Convert.ToInt32(medicalTestPackageId)));
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetUpcomingMedicalTestsCount(string patientId)
    {
        Mobile_GetUpcomingMedicalTestsCountBL objMobile_GetUpcomingMedicalTestsCountBL = new Mobile_GetUpcomingMedicalTestsCountBL();
        JsonClass objJsonClass = new JsonClass();
        objJsonClass.medicalTestCount = objMobile_GetUpcomingMedicalTestsCountBL.Mobile_GetUpcomingMedicalTestsCount(Convert.ToInt32(patientId));
        return JsonConvert.SerializeObject(objJsonClass);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetAppointmentDetails(string appointmentToken)
    {
        Mobile_GetAppointmentDetailsBL objMobile_GetAppointmentDetailsBL = new Mobile_GetAppointmentDetailsBL();
        return JsonConvert.SerializeObject(objMobile_GetAppointmentDetailsBL.Mobile_GetAppointmentDetails(appointmentToken));
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetPreviousAppointmentDetails(string appointmentToken)
    {
        Mobile_GetPreviousAppointmentDetailsBL objMobile_GetPastAppointmentDetailsBL = new Mobile_GetPreviousAppointmentDetailsBL();
        return JsonConvert.SerializeObject(objMobile_GetPastAppointmentDetailsBL.Mobile_GetPreviousAppointmentDetails(appointmentToken));
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetUpcomingMedicalTests(string patientId)
    {
        Mobile_GetUpcomingMedicalTestsBL objMobile_GetUpcomingMedicalTestsBL = new Mobile_GetUpcomingMedicalTestsBL();
        return JsonConvert.SerializeObject(objMobile_GetUpcomingMedicalTestsBL.Mobile_GetUpcomingMedicalTests(Convert.ToInt32(patientId)));
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetPreviousMedicalTests(string patientId)
    {
        Mobile_GetPreviousMedicalTestsBL objMobile_GetPreviousMedicalTestsBL = new Mobile_GetPreviousMedicalTestsBL();
        return JsonConvert.SerializeObject(objMobile_GetPreviousMedicalTestsBL.Mobile_GetPreviousMedicalTests(Convert.ToInt32(patientId)));
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetRoomTariff()
    {
        Mobile_GetWardTarrifBL objMobile_GetWardTarrifBL = new Mobile_GetWardTarrifBL();
        return JsonConvert.SerializeObject(objMobile_GetWardTarrifBL.Mobile_GetWardTarrif());
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetConsultationTariff()
    {
        Mobile_GetConsultationTariffBL objMobile_GetConsultationTariffBL = new Mobile_GetConsultationTariffBL();
        return JsonConvert.SerializeObject(objMobile_GetConsultationTariffBL.Mobile_GetConsultationTariff());
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string GetMiscTariff()
    {
        Mobile_GetMiscTariffBL objMobile_GetMiscTariffBL = new Mobile_GetMiscTariffBL();
        return JsonConvert.SerializeObject(objMobile_GetMiscTariffBL.Mobile_GetMiscTariff());
    }
}
