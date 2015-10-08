using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for AddCaseBL
/// </summary>
public class AddCaseBL
{
	public int AddCase(int doctorId, int patientId, string caseStartDate, string caseEndDate)
	{
        AddCaseBO objAddCaseBO = new AddCaseBO();
        objAddCaseBO.doctorId = doctorId;
        objAddCaseBO.patientId = patientId;
        objAddCaseBO.caseStartDate = caseStartDate;
        objAddCaseBO.caseEndDate = caseEndDate;

        AddCaseDL objAddCaseDL = new AddCaseDL();
        return objAddCaseDL.AddCase(objAddCaseBO);
	}
}