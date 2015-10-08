using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for FilterMessagePhoneCallDL
/// </summary>
public class FilterMessagePhoneCallDL
{
    public DataSet FilterMessagePhoneCall(FilterPhoneCallBO objFilterPhoneCallBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spFilterMessagePhoneCall", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", objFilterPhoneCallBO.empId);
        cmd.Parameters.Add("@fromDate", objFilterPhoneCallBO.fromDate);
        cmd.Parameters.Add("@toDate", objFilterPhoneCallBO.toDate);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}