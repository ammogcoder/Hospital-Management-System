using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddReminderDL
/// </summary>
public class AddReminderDL
{
    public void AddReminder(AddReminderBO objAddReminderBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddReminder", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", objAddReminderBO.empId);
        cmd.Parameters.Add("@reminderTitle", objAddReminderBO.reminderTitle);
        cmd.Parameters.Add("@reminderDetails", objAddReminderBO.reminderDetails);
        cmd.Parameters.Add("@reminderDate", objAddReminderBO.reminderDate);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}