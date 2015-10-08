using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetPatientDetailsByIPDObservationIDDL
/// </summary>
public class Doctor_GetPatientDetailsByIPDObservationIDDL
{
	public string Doctor_GetPatientDetailsByIPDObservationID(string ipdObservationId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetPatientDetailsByIPDObservationID", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationId", ipdObservationId);
        conn.Open();
        string patientName = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return patientName;
	}
}