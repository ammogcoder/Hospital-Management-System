using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPhoneCallForwardBL
/// </summary>
public class AddPhoneCallForwardBL
{
    public void AddPhoneCallForward(int receptionistId, string phoneNo, string callDate, string callTime, 
        string callerName, int callForwardedTo)
	{
        AddPhoneCallForwardBO objAddPhoneCallForwardBO = new AddPhoneCallForwardBO();
        objAddPhoneCallForwardBO.receptionistId = receptionistId;
        objAddPhoneCallForwardBO.phoneNo = phoneNo;
        objAddPhoneCallForwardBO.callDate = callDate;
        objAddPhoneCallForwardBO.callTime = callTime;
        objAddPhoneCallForwardBO.callerName = callerName;
        objAddPhoneCallForwardBO.callForwardedTo = callForwardedTo;

        AddPhoneCallForwardDL objAddPhoneCallForwardDL = new AddPhoneCallForwardDL();
        objAddPhoneCallForwardDL.AddPhoneCallForward(objAddPhoneCallForwardBO);
	}
}