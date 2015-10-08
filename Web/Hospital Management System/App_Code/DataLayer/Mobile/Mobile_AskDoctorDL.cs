using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Mobile_AskDoctorDL
/// </summary>
public class Mobile_AskDoctorDL
{
    public void Mobile_AskDoctor(Mobile_AskDoctorBO objMobile_AskDoctorBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Mobile_AskDoctor", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", objMobile_AskDoctorBO.patientId);
        cmd.Parameters.Add("@doctorId", objMobile_AskDoctorBO.doctorId);
        cmd.Parameters.Add("@problem", objMobile_AskDoctorBO.problem);
        cmd.Parameters.Add("@problemDetails", objMobile_AskDoctorBO.problemDetails);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}