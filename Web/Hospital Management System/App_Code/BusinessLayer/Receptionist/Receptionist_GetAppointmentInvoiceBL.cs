using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetAppointmentInvoiceBL
/// </summary>
public class GetAppointmentInvoiceBL
{
	public DataSet GetAppointmentInvoice()
	{
        GetAppointmentInvoiceDL objGetAppointmentInvoiceDL = new GetAppointmentInvoiceDL();
        return objGetAppointmentInvoiceDL.GetAppointmentInvoice();
	}
}