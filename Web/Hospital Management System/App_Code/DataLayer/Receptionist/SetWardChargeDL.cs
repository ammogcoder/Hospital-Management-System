using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SetWardChargeDL
/// </summary>
public class SetWardChargeDL
{
	public void SetWardCharge(SetWardChargeBO objSetWardChargeBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spSetWardCharge", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@suiteWardCharge", objSetWardChargeBO.suiteWardCharge);
        cmd.Parameters.Add("@deluxeWardCharge", objSetWardChargeBO.deluxeWardCharge);
        cmd.Parameters.Add("@specialAcWardCharge", objSetWardChargeBO.specialAcWardCharge);
        cmd.Parameters.Add("@semiWardPrivate", objSetWardChargeBO.semiWardPrivate);
        cmd.Parameters.Add("@generalWardCharge", objSetWardChargeBO.generalWardCharge);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}