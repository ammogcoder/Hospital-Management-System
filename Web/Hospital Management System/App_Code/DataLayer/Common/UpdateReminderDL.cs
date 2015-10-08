using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for UpdateReminderDL
/// </summary>
public class UpdateReminderDL
{
    public void UpdateReminder(AddReminderBO objUpdateReminderBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spUpdateReminder", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", objUpdateReminderBO.empId);
        cmd.Parameters.Add("@reminderId", objUpdateReminderBO.reminderId);
        cmd.Parameters.Add("@reminderTitle", objUpdateReminderBO.reminderTitle);
        cmd.Parameters.Add("@reminderDetails", objUpdateReminderBO.reminderDetails);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}