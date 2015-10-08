using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for GetMedicineNameByTypeDL
/// </summary>
public class Doctor_GetMedicineNameByTypeDL
{
	public DataSet Doctor_GetMedicineNameByType(int medicineTypeId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetMedicineNameByType", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@medicineTypeId", medicineTypeId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}