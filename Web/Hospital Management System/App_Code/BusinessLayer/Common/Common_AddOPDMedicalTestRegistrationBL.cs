using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common_AddOPDMedicalTestRegistrationBL
/// </summary>
public class Common_AddOPDMedicalTestRegistrationBL
{
	public int Common_AddOPDMedicalTestRegistration(int patientId, int medicalTestId,  
        string testDate, string testTime)
	{
        Common_AddOPDMedicalTestRegistrationBO objCommon_AddOPDMedicalTestRegistrationBO = new Common_AddOPDMedicalTestRegistrationBO();
        objCommon_AddOPDMedicalTestRegistrationBO.patientId = patientId;
        objCommon_AddOPDMedicalTestRegistrationBO.medicalTestId = medicalTestId;
        objCommon_AddOPDMedicalTestRegistrationBO.testDate = testDate;
        objCommon_AddOPDMedicalTestRegistrationBO.testTime = testTime;

        Common_AddOPDMedicalTestRegistrationDL objCommon_AddOPDMedicalTestRegistrationDL = new Common_AddOPDMedicalTestRegistrationDL();
        return objCommon_AddOPDMedicalTestRegistrationDL.Common_AddOPDMedicalTestRegistration(objCommon_AddOPDMedicalTestRegistrationBO);
	}
}