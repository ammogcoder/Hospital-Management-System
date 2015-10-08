using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPatientTypeBL
/// </summary>
public class AddPatientTypeBL
{
	public void AddPatientType(int patientId)
	{
        AddPatientTypeDL objAddPatientTypeDL = new AddPatientTypeDL();
        objAddPatientTypeDL.AddPatientType(patientId);
	}
}