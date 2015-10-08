using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_IPDDoctorTransferDL
/// </summary>
public class Doctor_IPDDoctorTransferDL
{
    public int Doctor_IPDDoctorTransfer(Doctor_IPDDoctorTransferBO objDoctor_IPDDoctorTransferBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_IPDDoctorTransfer", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@transferDate", objDoctor_IPDDoctorTransferBO.transferDate);
        cmd.Parameters.Add("@transferTime", objDoctor_IPDDoctorTransferBO.transferTime);
        cmd.Parameters.Add("@reasonForTransfer", objDoctor_IPDDoctorTransferBO.reasonForTransfer);
        cmd.Parameters.Add("@transferToDoctorId", objDoctor_IPDDoctorTransferBO.transferToDoctorId);
        cmd.Parameters.Add("@transferByDoctorId", objDoctor_IPDDoctorTransferBO.transferByDoctorId);
        cmd.Parameters.Add("@patientId", objDoctor_IPDDoctorTransferBO.patientId);

        conn.Open();
        int doctorTransferId = Convert.ToInt32((cmd.ExecuteScalar()).ToString());
        conn.Close();
        return doctorTransferId;
	}
}