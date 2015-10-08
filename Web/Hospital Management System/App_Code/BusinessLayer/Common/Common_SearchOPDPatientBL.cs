using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for SearchOPDPatientBL
/// </summary>
public class Common_SearchOPDPatientBL
{
	public DataSet Common_SearchOPDPatient(string patientName)
	{
        SearchOPDPatientDL objSearchOPDPatientDL = new SearchOPDPatientDL();
        return objSearchOPDPatientDL.SearchOPDPatient(patientName);
	}
}