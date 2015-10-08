using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Common_GetMedicalTestPackagesBL
/// </summary>
public class Common_GetMedicalTestPackagesBL
{
	public DataSet Common_GetMedicalTestPackages()
	{
		Common_GetMedicalTestPackagesDL objCommon_GetMedicalTestPackagesDL=new Common_GetMedicalTestPackagesDL();
        return objCommon_GetMedicalTestPackagesDL.Common_GetMedicalTestPackages();
	}
}