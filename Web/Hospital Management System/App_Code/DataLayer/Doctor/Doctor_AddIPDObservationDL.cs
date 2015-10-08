using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Doctor_AddIPDObservationDL
/// </summary>
public class Doctor_AddIPDObservationDL
{
    public int Doctor_AddIPDObservation(Doctor_AddIPDObservationBO objDoctor_AddIPDObservationBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("sp_Doctor_AddIPDObservation", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@ipdObservationId", objDoctor_AddIPDObservationBO.ipdObservationId);
        cmd.Parameters.Add("@doctorId", objDoctor_AddIPDObservationBO.doctorId);
        cmd.Parameters.Add("@patientId", objDoctor_AddIPDObservationBO.patientId);
        cmd.Parameters.Add("@observationDate", objDoctor_AddIPDObservationBO.observationDate);
        cmd.Parameters.Add("@observationTime", objDoctor_AddIPDObservationBO.observationTime);
        cmd.Parameters.Add("@patientHealthCondition", objDoctor_AddIPDObservationBO.patientHealthCondition);
        cmd.Parameters.Add("@transferToDoctorId", objDoctor_AddIPDObservationBO.transferToDoctorId);
        cmd.Parameters.Add("@wardTransferId", objDoctor_AddIPDObservationBO.wardTransferId);

        conn.Open();
        int ipdObservationId = Convert.ToInt32(cmd.ExecuteScalar());
        conn.Close();
        return ipdObservationId;
	}
}