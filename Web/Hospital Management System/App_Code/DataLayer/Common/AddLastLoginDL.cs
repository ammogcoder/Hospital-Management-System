using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddLastLoginDL
/// </summary>
public class AddLastLoginDL
{
    public void AddLastLogin(AddLastLoginBO objAddLastLoginBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddLastLogin", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", objAddLastLoginBO.empId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}