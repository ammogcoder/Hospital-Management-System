using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for FilterRemindersByAfterDateDL
/// </summary>
public class FilterRemindersByAfterDateDL
{
    public DataSet FilterRemindersByAfterDate(string reminderDate, int empId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spFilterRemindersByAfterDate", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@reminderDate", reminderDate);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        return ds;
	}
}