using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_PatientWardTransferDL
/// </summary>
public class Common_PatientWardTransferDL
{
    public int Common_PatientWardTransfer(Common_PatientWardTransferBO objCommon_PatientWardTransferBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spPatientWardTransfer", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", objCommon_PatientWardTransferBO.patientId);
        cmd.Parameters.Add("@previousWardId", objCommon_PatientWardTransferBO.previousWardId);
        cmd.Parameters.Add("@previousWardNumber", objCommon_PatientWardTransferBO.previousWardNumber);
        cmd.Parameters.Add("@transferTime", objCommon_PatientWardTransferBO.transferTime);
        cmd.Parameters.Add("@transferDate", objCommon_PatientWardTransferBO.transferDate);
        cmd.Parameters.Add("@reasonForTransfer", objCommon_PatientWardTransferBO.reasonForTransfer);
        cmd.Parameters.Add("@newWardId", objCommon_PatientWardTransferBO.newWardId);
        cmd.Parameters.Add("@newWardNumber", objCommon_PatientWardTransferBO.newWardNumber);
        cmd.Parameters.Add("@empId", objCommon_PatientWardTransferBO.empId);
        conn.Open();
        int wardTransferId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return wardTransferId;
	}
}