using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddAppointmentInvoiceBL
/// </summary>
public class AddAppointmentInvoiceBL
{
	public string AddAppointmentInvoice(int empId, string appointmentToken)
	{
        AddAppointmentInvoiceDL objAddAppointmentInvoiceDL = new AddAppointmentInvoiceDL();
        return objAddAppointmentInvoiceDL.AddAppointmentInvoice(empId, appointmentToken);
	}
}