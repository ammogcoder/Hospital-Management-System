using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor_ChangeIPDMedicineStatusBL
/// </summary>
public class Doctor_ChangeIPDMedicineStatusBL
{
    public void Doctor_ChangeIPDMedicineStatus(int ipdMedicineId, int ipdMedicineStatus)
	{
        Doctor_ChangeIPDMedicineStatusDL objDoctor_ChangeIPDMedicineStatusDL = new Doctor_ChangeIPDMedicineStatusDL();
        objDoctor_ChangeIPDMedicineStatusDL.Doctor_ChangeIPDMedicineStatus(ipdMedicineId, ipdMedicineStatus);
	}
}