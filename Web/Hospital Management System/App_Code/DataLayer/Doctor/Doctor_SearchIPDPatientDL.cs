using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_SearchIPDPatientDL
/// </summary>
public class Doctor_SearchIPDPatientDL
{
    public DataSet Doctor_SearchIPDPatient(string patientName, int doctorId)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        DataSet ds = new DataSet();
        cmd.CommandText = "sp_Doctor_SearchIPDPatient";
        cmd.Parameters.Add("@patientName", patientName);
        cmd.Parameters.Add("@doctorId", doctorId);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
    }
}