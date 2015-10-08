using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetOPDPatientDetailsForBillingBL
/// </summary>
public class GetOPDPatientDetailsForBillingBL
{
    public DataSet GetOPDPatientDetailsForBilling(int patientId)
	{
        GetOPDPatientDetailsForBillingDL objGetOPDPatientDetailsForBillingDL = new GetOPDPatientDetailsForBillingDL();
        return objGetOPDPatientDetailsForBillingDL.GetOPDPatientDetailsForBilling(patientId);
	}
}