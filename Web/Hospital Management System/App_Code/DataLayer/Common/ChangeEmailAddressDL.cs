using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for ChangeEmailAddressDL
/// </summary>
public class ChangeEmailAddressDL
{
    public void ChangeEmailAddress(int empId, string emailAddress)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spChangeEmailAddress", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@emailAddress", emailAddress);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}