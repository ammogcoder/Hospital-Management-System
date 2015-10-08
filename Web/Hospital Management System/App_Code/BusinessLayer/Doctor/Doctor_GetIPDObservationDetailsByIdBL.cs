using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationDetailsByIdBL
/// </summary>
public class Doctor_GetIPDObservationDetailsByIdBL
{
    public DataSet Doctor_GetIPDObservationDetailsById(string ipdObservationId)
	{
        Doctor_GetIPDObservationDetailsByIdDL objDoctor_GetIPDObservationDetailsByIdDL = new Doctor_GetIPDObservationDetailsByIdDL();
        return objDoctor_GetIPDObservationDetailsByIdDL.Doctor_GetIPDObservationDetailsById(ipdObservationId);
	}
}