using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for RegisterEmployeeReceptionistDL
/// </summary>
public class RegisterEmployeeReceptionistDL
{
    public int RegisterEmployeeReceptionist(RegisterEmployeeReceptionistBO objRegisterEmployeeReceptionistBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spRegisterReceptionist", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@receptionistEmpId", objRegisterEmployeeReceptionistBO.receptionistEmpId);
        cmd.Parameters.Add("@marks10", objRegisterEmployeeReceptionistBO.marks10);
        cmd.Parameters.Add("@marks12", objRegisterEmployeeReceptionistBO.marks12);
        conn.Open();
        int receptionistId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return receptionistId;
	}
}