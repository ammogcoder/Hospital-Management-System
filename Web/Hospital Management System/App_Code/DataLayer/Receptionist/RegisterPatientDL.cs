using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for RegisterPatientDL
/// </summary>
public class RegisterPatientDL
{

    public int RegisterPatient(RegisterPatientBO objRegisterPatientBO)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spRegisterPatient", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientFirstName", objRegisterPatientBO.patientFirstName);
        cmd.Parameters.Add("@patientMiddleName", objRegisterPatientBO.patientMiddleName);
        cmd.Parameters.Add("@patientLastName", objRegisterPatientBO.patientLastName);
        cmd.Parameters.Add("@patientDOB", objRegisterPatientBO.patientDOB);
        cmd.Parameters.Add("@patientGender", objRegisterPatientBO.patientGender);
        cmd.Parameters.Add("@patientMaritalStatus", objRegisterPatientBO.patientMaritalStatus);
        cmd.Parameters.Add("@patientFatherName", objRegisterPatientBO.patientFatherName);
        cmd.Parameters.Add("@patientPrimaryAddress", objRegisterPatientBO.patientPrimaryAddress);
        cmd.Parameters.Add("@patientSecondaryAddress", objRegisterPatientBO.patientSecondaryAddress);
        cmd.Parameters.Add("@patientPrimaryPhone", objRegisterPatientBO.patientPrimaryPhone);
        cmd.Parameters.Add("@patientSecondaryPhone", objRegisterPatientBO.patientSecondaryPhone);
        cmd.Parameters.Add("@patientEmail", objRegisterPatientBO.patientEmail);
        cmd.Parameters.Add("@patientEmergencyContactName", objRegisterPatientBO.patientEmergencyContactName);
        cmd.Parameters.Add("@patientEmergencyContactNumber", objRegisterPatientBO.patientEmergencyContactNumber);
        cmd.Parameters.Add("@patientOccupationType", objRegisterPatientBO.patientOccupationType);
        cmd.Parameters.Add("@patientOccupationName", objRegisterPatientBO.patientOccupationName);
        cmd.Parameters.Add("@patientOccupationAddress", objRegisterPatientBO.patientOccupationAddress);
        cmd.Parameters.Add("@patientMonthlyIncome", objRegisterPatientBO.patientMonthlyIncome);
        cmd.Parameters.Add("@patientReference", objRegisterPatientBO.patientReference);
        cmd.Parameters.Add("@patientReferenceSourceId", objRegisterPatientBO.patientReferenceSourceId);
        cmd.Parameters.Add("@patientPrimaryLanguage", objRegisterPatientBO.patientPrimaryLanguage);
        cmd.Parameters.Add("@patientFamilySize", objRegisterPatientBO.patientFamilySize);
        cmd.Parameters.Add("@patientRegisteredById", objRegisterPatientBO.patientRegisteredById);
        conn.Open();
        int patientId=Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return patientId;
    }
}