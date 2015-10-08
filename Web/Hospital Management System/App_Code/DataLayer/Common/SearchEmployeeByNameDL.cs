using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SearchEmployeeByNameDL
/// </summary>
public class SearchEmployeeByNameDL
{
	public DataSet SearchEmployeeByName(string empName)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        DataSet ds = new DataSet();
        cmd.CommandText = "spSearchEmployeeByName";
        cmd.Parameters.Add("@empName", empName);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}