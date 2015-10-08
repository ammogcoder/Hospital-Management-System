using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPatientDetailsBL
/// </summary>
public class Common_GetPatientDetailsBL
{
	public DataSet Common_GetPatientDetails(int patientId)
	{
        GetPatientDetailsDL objGetPatientDetailsDL = new GetPatientDetailsDL();
        return objGetPatientDetailsDL.GetPatientDetails(patientId);
	}
}