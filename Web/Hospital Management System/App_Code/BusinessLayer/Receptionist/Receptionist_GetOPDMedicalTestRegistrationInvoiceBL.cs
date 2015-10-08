using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetOPDMedicalTestRegistrationInvoiceBL
/// </summary>
public class GetOPDMedicalTestRegistrationInvoiceBL
{
	public DataSet GetOPDMedicalTestRegistrationInvoice()
	{
        GetOPDMedicalTestRegistrationInvoiceDL objGetOPDMedicalTestRegistrationInvoiceDL = new GetOPDMedicalTestRegistrationInvoiceDL();
        return objGetOPDMedicalTestRegistrationInvoiceDL.GetOPDMedicalTestRegistrationInvoice();
	}
}