using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetSMSTemplateDL
/// </summary>
public class GetSMSTemplateDL
{
	public string GetSMSTemplate(int templateId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetSMSTemplate", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@templateId", templateId);
        conn.Open();
        string smsTemplate = cmd.ExecuteScalar().ToString();
        conn.Close();
        return smsTemplate;
	}
}