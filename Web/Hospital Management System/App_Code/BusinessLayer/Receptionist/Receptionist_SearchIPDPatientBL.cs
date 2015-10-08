using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Receptionist_SearchIPDPatientBL
/// </summary>
public class Receptionist_SearchIPDPatientBL
{
    public DataSet Receptionist_SearchIPDPatient(string patientName)
	{
        Receptionist_SearchIPDPatientDL objReceptionist_SearchIPDPatientDL = new Receptionist_SearchIPDPatientDL();
        return objReceptionist_SearchIPDPatientDL.Receptionist_SearchIPDPatient(patientName);
	}
}