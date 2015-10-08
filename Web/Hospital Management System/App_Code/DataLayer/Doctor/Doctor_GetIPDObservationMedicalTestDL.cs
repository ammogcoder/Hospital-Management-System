using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationMedicalTestDL
/// </summary>
public class Doctor_GetIPDObservationMedicalTestDL
{
    public DataSet Doctor_GetIPDObservationMedicalTest(string ipdObservationId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetIPDObservationMedicalTest", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("ipdObservationId", ipdObservationId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}