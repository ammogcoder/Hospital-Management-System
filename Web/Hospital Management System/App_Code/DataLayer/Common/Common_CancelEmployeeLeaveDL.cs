using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_CancelEmployeeLeaveDL
/// </summary>
public class Common_CancelEmployeeLeaveDL
{
	public void Common_CancelEmployeeLeave(int empId, int leaveId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Common_CancelEmployeeLeave", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@leaveId", leaveId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}