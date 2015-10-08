using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Common_GetMedicalTestPackageComponentsDL
/// </summary>
public class Common_GetMedicalTestPackageComponentsDL
{
    public DataSet Common_GetMedicalTestPackageComponents(int medicalTestPackageId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Common_GetMedicalTestPackageComponents", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@medicalTestPackageId", medicalTestPackageId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        return ds;
	}
}