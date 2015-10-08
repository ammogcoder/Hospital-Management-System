using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Common_GetMedicalTestPackageComponentsBL
/// </summary>
public class Common_GetMedicalTestPackageComponentsBL
{
    public DataSet Common_GetMedicalTestPackageComponents(int medicalTestPackageId)
	{
        Common_GetMedicalTestPackageComponentsDL objCommon_GetMedicalTestPackageComponentsDL = new Common_GetMedicalTestPackageComponentsDL();
        return objCommon_GetMedicalTestPackageComponentsDL.Common_GetMedicalTestPackageComponents(medicalTestPackageId);
	}
}