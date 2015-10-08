using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GetMedicalTestByIdBL
/// </summary>
public class GetMedicalTestByIdBL
{
	public string GetMedicalTestById(int medicalTestId)
	{
        GetMedicalTestByIdDL objGetMedicalTestByIdDL = new GetMedicalTestByIdDL();
        return objGetMedicalTestByIdDL.GetMedicalTestById(medicalTestId);
	}
}