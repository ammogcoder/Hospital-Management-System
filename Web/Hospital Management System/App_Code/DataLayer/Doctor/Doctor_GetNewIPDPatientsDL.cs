using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetNewIPDPatientsDL
/// </summary>
public class Doctor_GetNewIPDPatientsDL
{
    public DataSet Doctor_GetNewIPDPatients(int doctorId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetNewIPDPatients", conn);
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