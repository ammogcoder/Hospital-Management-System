using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for EditAppointmentDL
/// </summary>
public class EditAppointmentDL
{
	public void EditAppointment(EditAppointmentBO objEditAppointmentBO)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spEditAppointment", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@appointmentToken", objEditAppointmentBO.appointmentToken);
        cmd.Parameters.Add("@oldAppointmentDate", objEditAppointmentBO.oldAppointmentDate);
        cmd.Parameters.Add("@newAppointmentDate", objEditAppointmentBO.newAppointmentDate);
        cmd.Parameters.Add("@newAppointmentTime", objEditAppointmentBO.newAppointmentTime);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
	}
}