using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for EmployeeNameDL
/// </summary>
public class EmployeeNameDL
{
	public string EmployeeName(int empId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetEmployeeName", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        conn.Open();
        string empName = cmd.ExecuteScalar().ToString();
        conn.Close();
        return empName;
	}
}