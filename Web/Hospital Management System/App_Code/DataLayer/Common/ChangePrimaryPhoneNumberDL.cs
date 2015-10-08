using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for ChangePrimaryPhoneNumberDL
/// </summary>
public class ChangePrimaryPhoneNumberDL
{
	public void ChangePrimaryPhoneNumber(int empId, string primaryPhoneNumber)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spChangePrimaryPhoneNumber", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@primaryPhoneNumber", primaryPhoneNumber);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}