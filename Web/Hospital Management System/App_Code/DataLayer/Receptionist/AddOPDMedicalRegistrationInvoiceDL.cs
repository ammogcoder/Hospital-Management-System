using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for AddOPDMedicalRegistrationInvoiceDL
/// </summary>
public class AddOPDMedicalRegistrationInvoiceDL
{
    public string AddOPDMedicalRegistrationInvoice(int empId, int opdMedicalTestRegistrationId)
	{
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand("spAddOPDMedicalRegistrationInvoice", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@empId", empId);
        cmd.Parameters.Add("@opdMedicalTestRegistrationId", opdMedicalTestRegistrationId);
        conn.Open();
        string invoiceId = (cmd.ExecuteScalar()).ToString();
        conn.Close();
        return invoiceId;
	}
}