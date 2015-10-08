using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UpdatePatientTypeBL
/// </summary>
public class UpdatePatientTypeBL
{
    public void UpdatePatientType(int patientId, string patientType)
	{
        UpdatePatientTypeDL objUpdatePatientTypeDL = new UpdatePatientTypeDL();
        objUpdatePatientTypeDL.UpdatePatientType(patientId, patientType);
	}
}