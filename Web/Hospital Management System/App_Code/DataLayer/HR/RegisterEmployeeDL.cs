using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for RegisterEmployeeDL
/// </summary>
public class RegisterEmployeeDL
{
    public int RegisterEmployee(RegisterEmployeeBO objRegisterEmployeeBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spRegisterEmployee", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empName", objRegisterEmployeeBO.empName);
        cmd.Parameters.Add("@empGender", objRegisterEmployeeBO.empGender);
        cmd.Parameters.Add("@empDOB", objRegisterEmployeeBO.empDOB);
        cmd.Parameters.Add("@empAddress", objRegisterEmployeeBO.empAddress);
        cmd.Parameters.Add("@empPhoneNumber", objRegisterEmployeeBO.empPhoneNumber);
        cmd.Parameters.Add("@empEmailAddress", objRegisterEmployeeBO.empEmailAddress);
        cmd.Parameters.Add("@empType", objRegisterEmployeeBO.empType);
        cmd.Parameters.Add("@empDateOfJoin", objRegisterEmployeeBO.empDateOfJoin);
        cmd.Parameters.Add("@empDateOfLeave", objRegisterEmployeeBO.empDateOfLeave);
        cmd.Parameters.Add("@empBank", objRegisterEmployeeBO.empBank);
        cmd.Parameters.Add("@empAccountNumber", objRegisterEmployeeBO.empAccountNumber);

        conn.Open();
        int id = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return id;
	}
}