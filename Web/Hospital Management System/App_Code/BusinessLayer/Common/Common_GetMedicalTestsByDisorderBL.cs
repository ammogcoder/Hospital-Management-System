using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Common_GetMedicalTestsByDisorderBL
/// </summary>
public class Common_GetMedicalTestsByDisorderBL
{
	public DataSet Common_GetMedicalTestsByDisorder()
	{
        Common_GetMedicalTestsByDisorderDL objCommon_GetMedicalTestsByDisorderDL = new Common_GetMedicalTestsByDisorderDL();
        return objCommon_GetMedicalTestsByDisorderDL.Common_GetMedicalTestsByDisorder();
	}
}