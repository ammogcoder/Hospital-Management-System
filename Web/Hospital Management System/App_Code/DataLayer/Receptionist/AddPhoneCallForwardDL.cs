using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for AddPhoneCallForwardDL
/// </summary>
public class AddPhoneCallForwardDL
{
    public void AddPhoneCallForward(AddPhoneCallForwardBO objAddPhoneCallForwardBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddPhoneCallForward", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@receptionistId", objAddPhoneCallForwardBO.receptionistId);
        cmd.Parameters.Add("@phoneNo", objAddPhoneCallForwardBO.phoneNo);
        cmd.Parameters.Add("@callDate", objAddPhoneCallForwardBO.callDate);
        cmd.Parameters.Add("@callTime", objAddPhoneCallForwardBO.callTime);
        cmd.Parameters.Add("@callerName", objAddPhoneCallForwardBO.callerName);
        cmd.Parameters.Add("@callForwardedTo", objAddPhoneCallForwardBO.callForwardedTo);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}