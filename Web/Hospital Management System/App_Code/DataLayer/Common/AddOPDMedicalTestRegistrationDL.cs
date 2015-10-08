using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_AddOPDMedicalTestRegistrationDL
/// </summary>
public class Common_AddOPDMedicalTestRegistrationDL
{
    public int Common_AddOPDMedicalTestRegistration(Common_AddOPDMedicalTestRegistrationBO objAddOPDMedicalTestRegistrationBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddOPDMedicalTestRegistration", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", objAddOPDMedicalTestRegistrationBO.patientId);
        cmd.Parameters.Add("@medicalTestId", objAddOPDMedicalTestRegistrationBO.medicalTestId);
        cmd.Parameters.Add("@testDate", objAddOPDMedicalTestRegistrationBO.testDate);
        cmd.Parameters.Add("@testTime", objAddOPDMedicalTestRegistrationBO.testTime);
        conn.Open();
        int opdMedicalTestRegistrationId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return opdMedicalTestRegistrationId;
	}
}