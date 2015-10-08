using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_DeleteReminderDL
/// </summary>
public class Common_DeleteReminderDL
{
	public void Common_DeleteReminder(int reminderId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Common_DeleteReminder", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@reminderId", reminderId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}