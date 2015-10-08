using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddOPDMedicalRegistrationInvoiceBL
/// </summary>
public class AddOPDMedicalRegistrationInvoiceBL
{
	public string AddOPDMedicalRegistrationInvoice(int empId, int opdMedicalTestRegistrationId)
	{
        AddOPDMedicalRegistrationInvoiceDL objAddOPDMedicalRegistrationInvoiceDL = new AddOPDMedicalRegistrationInvoiceDL();
        return objAddOPDMedicalRegistrationInvoiceDL.AddOPDMedicalRegistrationInvoice(empId, opdMedicalTestRegistrationId);
	}
}