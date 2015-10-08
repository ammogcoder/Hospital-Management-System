using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetPhoneCallForwardDL
/// </summary>
public class GetPhoneCallForwardDL
{
    public DataSet GetPhoneCallForward(int empId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetPhoneCallForward", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("empId", empId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}