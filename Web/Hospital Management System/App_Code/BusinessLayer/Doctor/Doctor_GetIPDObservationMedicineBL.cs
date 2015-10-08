using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDObservationMedicineBL
/// </summary>
public class Doctor_GetIPDObservationMedicineBL
{
    public DataSet Doctor_GetIPDObservationMedicine(string ipdObservationId)
	{
        Doctor_GetIPDObservationMedicineDL objDoctor_GetIPDObservationMedicineDL = new Doctor_GetIPDObservationMedicineDL();
        return objDoctor_GetIPDObservationMedicineDL.Doctor_GetIPDObservationMedicine(ipdObservationId);
	}
}