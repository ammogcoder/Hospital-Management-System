using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetBodyPartsDL
/// </summary>
public class Mobile_GetBodyPartsDL
{
	public DataSet Mobile_GetBodyParts()
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_GetBodyParts", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}