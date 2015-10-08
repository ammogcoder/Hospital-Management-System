using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddPhoneCallMessageDL
/// </summary>
public class AddPhoneCallMessageDL
{
    public void AddPhoneCallMessage(AddPhoneCallMessageBO objAddPhoneCallMessageBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddPhoneCallMessage", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@receptionistId", objAddPhoneCallMessageBO.receptionistId);
        cmd.Parameters.Add("@phoneNo", objAddPhoneCallMessageBO.phoneNo);
        cmd.Parameters.Add("@callDate", objAddPhoneCallMessageBO.callDate);
        cmd.Parameters.Add("@callTime", objAddPhoneCallMessageBO.callTime);
        cmd.Parameters.Add("@callerName", objAddPhoneCallMessageBO.callerName);
        cmd.Parameters.Add("@messageFor", objAddPhoneCallMessageBO.messageFor);
        cmd.Parameters.Add("@message", objAddPhoneCallMessageBO.message);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}