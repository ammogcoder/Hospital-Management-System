using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Doctor_GetDoctorByDepartmentDL
/// </summary>
public class Doctor_GetDoctorByDepartmentDL
{
    public DataSet Doctor_GetDoctorByDepartment(int departmentId, int empId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_GetDoctorByDepartment", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@departmentId", departmentId);
        cmd.Parameters.Add("@empId", empId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}