using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for RegisterIndoorPatientDL
/// </summary>
public class RegisterIndoorPatientDL
{
    public int RegisterIndoorPatient(RegisterIndoorPatientBO objRegisterIndoorPatientBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spRegisterIndoorPatient", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", objRegisterIndoorPatientBO.patientId);
        cmd.Parameters.Add("@patientGeneralHealth", objRegisterIndoorPatientBO.patientGeneralHealth);
        cmd.Parameters.Add("@patientRegularMedications", objRegisterIndoorPatientBO.patientRegularMedications);
        cmd.Parameters.Add("@patientAllergyStatus", objRegisterIndoorPatientBO.patientAllergyStatus);
        cmd.Parameters.Add("@patientAllergies", objRegisterIndoorPatientBO.patientAllergies);
        cmd.Parameters.Add("@patientPastSurgeryStatus", objRegisterIndoorPatientBO.patientPastSurgeryStatus);
        cmd.Parameters.Add("@patientSurgery1", objRegisterIndoorPatientBO.patientSurgery1);
        cmd.Parameters.Add("@patientSurgery1Date", objRegisterIndoorPatientBO.patientSurgery1Date);
        cmd.Parameters.Add("@patientSurgery2", objRegisterIndoorPatientBO.patientSurgery2);
        cmd.Parameters.Add("@patientSurgery2Date", objRegisterIndoorPatientBO.patientSurgery2Date);
        cmd.Parameters.Add("@patientSurgery3", objRegisterIndoorPatientBO.patientSurgery3);
        cmd.Parameters.Add("@patientSurgery3Date", objRegisterIndoorPatientBO.patientSurgery3Date);
        cmd.Parameters.Add("@patientMedicalInsuranceStatus", objRegisterIndoorPatientBO.patientMedicalInsuranceStatus);
        cmd.Parameters.Add("@patientMedicalInsuranceProvider", objRegisterIndoorPatientBO.patientMedicalInsuranceProvider);
        cmd.Parameters.Add("@patientMedicalInsurancePolicyNumber", objRegisterIndoorPatientBO.patientMedicalInsurancePolicyNumber);
        cmd.Parameters.Add("@patientHeight", objRegisterIndoorPatientBO.patientHeight);
        cmd.Parameters.Add("@patientWeight", objRegisterIndoorPatientBO.patientWeight);
        cmd.Parameters.Add("@patientBloodGroup", objRegisterIndoorPatientBO.patientBloodGroup);
        cmd.Parameters.Add("@patientAttendingDoctor", objRegisterIndoorPatientBO.patientAttendingDoctor);
        cmd.Parameters.Add("@patientDateOfAdmit", objRegisterIndoorPatientBO.patientDateOfAdmit);
        cmd.Parameters.Add("@patientTimeOfAdmit", objRegisterIndoorPatientBO.patientTimeOfAdmit);
        cmd.Parameters.Add("@patientRemark", objRegisterIndoorPatientBO.patientRemark);

        conn.Open();
        int ipdId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return ipdId;
	}
}