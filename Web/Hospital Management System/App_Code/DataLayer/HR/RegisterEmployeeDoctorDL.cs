using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for RegisterPersonnelDoctorDL
/// </summary>
public class RegisterEmployeeDoctorDL
{
    public void RegisterEmployeeDoctor(RegisterEmployeeDoctorBO objRegisterEmployeeDoctorBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spRegisterDoctor", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@doctorEmpId", objRegisterEmployeeDoctorBO.doctorEmpId);
        cmd.Parameters.Add("@doctorLicenseNumber", objRegisterEmployeeDoctorBO.doctorLicenseNumber);
        cmd.Parameters.Add("@doctorDepartment", objRegisterEmployeeDoctorBO.doctorDepartment);
        cmd.Parameters.Add("@doctorDegree", objRegisterEmployeeDoctorBO.doctorDegree);
        cmd.Parameters.Add("@doctorUniversityName", objRegisterEmployeeDoctorBO.doctorUniversityName);
        cmd.Parameters.Add("@doctorUniversityCity", objRegisterEmployeeDoctorBO.doctorUniversityCity);
        cmd.Parameters.Add("@doctorUniversityState", objRegisterEmployeeDoctorBO.doctorUniversityState);
        cmd.Parameters.Add("@doctorUniversityCountry", objRegisterEmployeeDoctorBO.doctorUniversityCountry);
        cmd.Parameters.Add("@doctorExperience", objRegisterEmployeeDoctorBO.doctorExperience);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}