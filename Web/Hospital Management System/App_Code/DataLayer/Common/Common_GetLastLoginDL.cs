using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_GetLastLoginDL
/// </summary>
public class Common_GetLastLoginDL
{
    public string Common_GetLastLogin(int empId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Common_GetLastLogin", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        DataSet ds = new DataSet();
        conn.Open();
        string lastLogin = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return lastLogin;
	}
}