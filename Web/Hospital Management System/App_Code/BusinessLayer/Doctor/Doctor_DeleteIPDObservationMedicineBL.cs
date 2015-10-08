using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_DeleteIPDObservationMedicineBL
/// </summary>
public class Doctor_DeleteIPDObservationMedicineBL
{
    public void Doctor_DeleteIPDObservationMedicine(int ipdObservationMedicineId)
	{
        Doctor_DeleteIPDObservationMedicineDL objDoctor_DeleteIPDObservationMedicineDL = new Doctor_DeleteIPDObservationMedicineDL();
        objDoctor_DeleteIPDObservationMedicineDL.Doctor_DeleteIPDObservationMedicine(ipdObservationMedicineId);
	}
}