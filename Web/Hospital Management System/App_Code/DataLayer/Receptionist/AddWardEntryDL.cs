using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for AddWardEntryDL
/// </summary>
public class AddWardEntryDL
{
	public void AddWardEntry(AddWardEntryBO objAddWardEntryBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddWardEntry", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@wardId", objAddWardEntryBO.wardId);
        cmd.Parameters.Add("@wardNumber", objAddWardEntryBO.wardNumber);
        cmd.Parameters.Add("@patientId", objAddWardEntryBO.patientId);
        cmd.Parameters.Add("@caseId", objAddWardEntryBO.caseId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}