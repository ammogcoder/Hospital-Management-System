using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetPatientDetailsByIPDObservationIDBL
/// </summary>
public class Doctor_GetPatientDetailsByIPDObservationIDBL
{
    public string Doctor_GetPatientDetailsByIPDObservationID(string ipdObservationId)
	{
        Doctor_GetPatientDetailsByIPDObservationIDDL objDoctor_GetPatientDetailsByIPDObservationIDDL = new Doctor_GetPatientDetailsByIPDObservationIDDL();
        return objDoctor_GetPatientDetailsByIPDObservationIDDL.Doctor_GetPatientDetailsByIPDObservationID(ipdObservationId);
	}
}