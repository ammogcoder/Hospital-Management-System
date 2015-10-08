using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for ChangePasswordDL
/// </summary>
public class ChangePasswordDL
{
	public void ChangePassword(int empId, string password)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spChangePassword", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@password", password);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}