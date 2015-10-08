using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_ChangeIPDMedicineStatusDL
/// </summary>
public class Doctor_ChangeIPDMedicineStatusDL
{
	public void Doctor_ChangeIPDMedicineStatus(int ipdMedicineId, int ipdMedicineStatus)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_ChangeIPDMedicineStatus", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        if(ipdMedicineStatus==0)
            cmd.Parameters.Add("@ipdMedicineStatus", "Inactive");
        else
            cmd.Parameters.Add("@ipdMedicineStatus", "Active");
        cmd.Parameters.Add("@ipdMedicineId", ipdMedicineId);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}