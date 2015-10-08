using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_LeaveApplicationDL
/// </summary>
public class Doctor_LeaveApplicationDL
{
    public void Doctor_LeaveApplication(Doctor_LeaveApplicationBO objDoctor_LeaveApplicationBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_LeaveApplication", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@doctorId", objDoctor_LeaveApplicationBO.doctorId);
        cmd.Parameters.Add("@leaveFromDate", objDoctor_LeaveApplicationBO.leaveFromDate);
        cmd.Parameters.Add("@leaveFromTime", objDoctor_LeaveApplicationBO.leaveFromTime);
        cmd.Parameters.Add("@leaveToDate", objDoctor_LeaveApplicationBO.leaveToDate);
        cmd.Parameters.Add("@leaveToTime", objDoctor_LeaveApplicationBO.leaveToTime);
        cmd.Parameters.Add("@leaveReason", objDoctor_LeaveApplicationBO.leaveReason);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}