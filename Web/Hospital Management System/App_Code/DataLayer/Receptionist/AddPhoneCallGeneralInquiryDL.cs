using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for AddPhoneCallGeneralInquiryDL
/// </summary>
public class AddPhoneCallGeneralInquiryDL
{
    public void AddPhoneCallGeneralInquiry(AddPhoneCallGeneralInquiryBO objAddPhoneCallGeneralInquiryBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddPhoneCallGeneralInquiry", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@receptionistId", objAddPhoneCallGeneralInquiryBO.receptionistId);
        cmd.Parameters.Add("@phoneNo", objAddPhoneCallGeneralInquiryBO.phoneNo);
        cmd.Parameters.Add("@callDate", objAddPhoneCallGeneralInquiryBO.callDate);
        cmd.Parameters.Add("@callTime", objAddPhoneCallGeneralInquiryBO.callTime);
        cmd.Parameters.Add("@callerName", objAddPhoneCallGeneralInquiryBO.callerName);
        cmd.Parameters.Add("@callerQuery", objAddPhoneCallGeneralInquiryBO.callerQuery);
        cmd.Parameters.Add("@callOutcome", objAddPhoneCallGeneralInquiryBO.callOutcome);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}