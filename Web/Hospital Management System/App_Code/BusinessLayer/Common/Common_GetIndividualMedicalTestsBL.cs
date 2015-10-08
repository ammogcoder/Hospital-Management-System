using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Common_GetIndividualMedicalTestsBL
/// </summary>
public class Common_GetIndividualMedicalTestsBL
{
	public DataSet Common_GetIndividualMedicalTests()
	{
        Common_GetIndividualMedicalTestsDL objCommon_GetIndividualMedicalTestsDL = new Common_GetIndividualMedicalTestsDL();
        return objCommon_GetIndividualMedicalTestsDL.Common_GetIndividualMedicalTests();
	}
}