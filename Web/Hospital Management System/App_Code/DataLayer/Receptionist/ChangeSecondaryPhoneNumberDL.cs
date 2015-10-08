using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for ChangeSecondaryPhoneNumberDL
/// </summary>
public class ChangeSecondaryPhoneNumberDL
{
    public void ChangeSecondaryPhoneNumber(int empId, string secondaryPhoneNumber)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spChangeSecondaryPhoneNumber", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@secondaryPhoneNumber", secondaryPhoneNumber);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}