using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_LoginDL
/// </summary>
public class Mobile_LoginDL
{
    public DataSet Mobile_Login(string patientPhone, string patientPassword)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_Login", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientPhone", patientPhone);
        cmd.Parameters.Add("@patientPassword", patientPassword);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}