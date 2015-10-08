using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPhoneCallEmergencyBL
/// </summary>
public class AddPhoneCallEmergencyBL
{
    public void AddPhoneCallEmergency(int receptionistId, string phoneNo, string callDate, string callTime, 
        string callerName, string callerArea, string emergencyDetails)
	{
        AddPhoneCallEmergencyBO objAddPhoneCallEmergencyBO = new AddPhoneCallEmergencyBO();
        objAddPhoneCallEmergencyBO.receptionistId = receptionistId;
        objAddPhoneCallEmergencyBO.phoneNo = phoneNo;
        objAddPhoneCallEmergencyBO.callDate = callDate;
        objAddPhoneCallEmergencyBO.callTime = callTime;
        objAddPhoneCallEmergencyBO.callerName = callerName;
        objAddPhoneCallEmergencyBO.callerArea = callerArea;
        objAddPhoneCallEmergencyBO.emergencyDetails = emergencyDetails;

        AddPhoneCallEmergencyDL objAddPhoneCallEmergencyDL = new AddPhoneCallEmergencyDL();
        objAddPhoneCallEmergencyDL.AddPhoneCallEmergency(objAddPhoneCallEmergencyBO);
	}
}