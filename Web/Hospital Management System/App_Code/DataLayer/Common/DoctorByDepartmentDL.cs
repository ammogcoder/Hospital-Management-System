using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for DoctorByDepartmentDL
/// </summary>
public class DoctorByDepartmentDL
{
	public DataSet DoctorByDepartment(int departmentId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spGetDoctorByDepartment", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@departmentId", departmentId);
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        conn.Open();
        adapter.Fill(ds);
        conn.Close();
        return ds;
	}
}