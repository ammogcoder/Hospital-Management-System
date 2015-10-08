using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetCurrentIPDPatientsDL
/// </summary>
public class Doctor_GetCurrentIPDPatientsDL
{
    public DataSet Doctor_GetCurrentIPDPatients(int doctorId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetCurrentIPDPatients", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@doctorId", doctorId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}