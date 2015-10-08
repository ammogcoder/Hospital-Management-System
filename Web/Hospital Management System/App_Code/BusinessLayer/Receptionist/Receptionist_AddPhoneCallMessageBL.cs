using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPhoneCallMessageBL
/// </summary>
public class AddPhoneCallMessageBL
{
    public void AddPhoneCallMessage(int receptionistId, string phoneNo, string callDate, string callTime,
        string callerName, int messageFor, string message)
    {
        AddPhoneCallMessageBO objAddPhoneCallMessageBO = new AddPhoneCallMessageBO();
        objAddPhoneCallMessageBO.receptionistId = receptionistId;
        objAddPhoneCallMessageBO.phoneNo = phoneNo;
        objAddPhoneCallMessageBO.callDate = callDate;
        objAddPhoneCallMessageBO.callTime = callTime;
        objAddPhoneCallMessageBO.callerName = callerName;
        objAddPhoneCallMessageBO.messageFor = messageFor;
        objAddPhoneCallMessageBO.message = message;

        AddPhoneCallMessageDL objAddPhoneCallMessageDL = new AddPhoneCallMessageDL();
        objAddPhoneCallMessageDL.AddPhoneCallMessage(objAddPhoneCallMessageBO);
    }
}