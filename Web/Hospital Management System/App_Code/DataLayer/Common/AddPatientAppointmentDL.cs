using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddPatientAppointmentDL
/// </summary>
public class AddPatientAppointmentDL
{
    public string AddPatientAppointment(AddPatientAppointmentBO objAddPatientAppointmentBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddPatientAppointment", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@patientId", objAddPatientAppointmentBO.patientId);
        cmd.Parameters.Add("@doctorId", objAddPatientAppointmentBO.doctorId);
        cmd.Parameters.Add("@appointmentDate", objAddPatientAppointmentBO.appointmentDate);
        cmd.Parameters.Add("@appointmentTime", objAddPatientAppointmentBO.appointmentTime);
        cmd.Parameters.Add("@problemBodyPartId", objAddPatientAppointmentBO.problemBodyPartId);
        cmd.Parameters.Add("@problemDescription", objAddPatientAppointmentBO.problemDescription);

        conn.Open();
        string appointmentToken = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return appointmentToken;
	}
}