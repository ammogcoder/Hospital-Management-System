using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for AddPhoneCallEmergencyDL
/// </summary>
public class AddPhoneCallEmergencyDL
{
    public void AddPhoneCallEmergency(AddPhoneCallEmergencyBO objAddPhoneCallEmergencyBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddPhoneCallEmergency", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@receptionistId", objAddPhoneCallEmergencyBO.receptionistId);
        cmd.Parameters.Add("@phoneNo", objAddPhoneCallEmergencyBO.phoneNo);
        cmd.Parameters.Add("@callDate", objAddPhoneCallEmergencyBO.callDate);
        cmd.Parameters.Add("@callTime", objAddPhoneCallEmergencyBO.callTime);
        cmd.Parameters.Add("@callerArea", objAddPhoneCallEmergencyBO.callerArea);
        cmd.Parameters.Add("@callerName", objAddPhoneCallEmergencyBO.callerName);
        cmd.Parameters.Add("@emergencyDetails", objAddPhoneCallEmergencyBO.emergencyDetails);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}