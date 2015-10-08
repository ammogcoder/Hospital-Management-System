using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetMedicineNameByTypeBL
/// </summary>
public class Doctor_GetMedicineNameByTypeBL
{
	public DataSet Doctor_GetMedicineNameByType(int medicineTypeId)
	{
        Doctor_GetMedicineNameByTypeDL objGetMedicineNameByTypeDL = new Doctor_GetMedicineNameByTypeDL();
        return objGetMedicineNameByTypeDL.Doctor_GetMedicineNameByType(medicineTypeId);
	}
}