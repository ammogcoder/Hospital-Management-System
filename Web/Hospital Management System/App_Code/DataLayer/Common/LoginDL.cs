using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for LoginDL
/// </summary>
public class LoginDL
{
	public void InsertTemporaryLogin(LoginBO objLoginBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddTemporaryLogin", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", objLoginBO.empId);
        cmd.Parameters.Add("@empUsername", objLoginBO.empUsername);
        cmd.Parameters.Add("@empPassword", objLoginBO.empPassword);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}

    public int Login(LoginBO objLoginBO)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spLogin", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empUsername", objLoginBO.empUsername);
        cmd.Parameters.Add("@empPassword", objLoginBO.empPassword);
        conn.Open();
        int empId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return empId;
    }
}