using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for GetWardNumberDL
/// </summary>
public class GetWardNumberDL
{
    public DataSet GetWardNumber(int wardId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetWardNumber", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@wardId", wardId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        return ds;
	}
}