using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SearchOPDPatientDL
/// </summary>
public class SearchOPDPatientDL
{
    public DataSet SearchOPDPatient(string patientName)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        DataSet ds = new DataSet();
        cmd.CommandText = "spSearchOPDPatient";
        cmd.Parameters.Add("@patientName", patientName);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}