using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetEmployeeNameByIdDL
/// </summary>
public class GetEmployeeNameByIdDL
{
	public string GetEmployeeNameById(int empId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetEmployeeNameById", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        string empName = cmd.ExecuteScalar().ToString();
        conn.Close();
        return empName;
	}
}