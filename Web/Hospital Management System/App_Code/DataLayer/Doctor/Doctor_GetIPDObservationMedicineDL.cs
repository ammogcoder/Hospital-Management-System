using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationMedicineDL
/// </summary>
public class Doctor_GetIPDObservationMedicineDL
{
    public DataSet Doctor_GetIPDObservationMedicine(string ipdObservationId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetIPDObservationMedicine", conn);
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