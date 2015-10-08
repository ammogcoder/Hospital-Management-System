using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddAppointmentInvoiceDL
/// </summary>
public class AddAppointmentInvoiceDL
{
	public string AddAppointmentInvoice(int empId, string appointmentToken)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddAppointmentInvoice", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@appointmentToken", appointmentToken);
        conn.Open();
        string invoiceId = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return invoiceId;
	}
}