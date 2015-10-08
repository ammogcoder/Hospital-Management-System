using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_GetMedicalTestPackagesDL
/// </summary>
public class Common_GetMedicalTestPackagesDL
{
	public DataSet Common_GetMedicalTestPackages()
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Common_GetMedicalTestPackages", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        return ds;
	}
}