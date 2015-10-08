using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddPhoneCallGeneralInquiryBL
/// </summary>
public class AddPhoneCallGeneralInquiryBL
{
    public void AddPhoneCallGeneralInquiry(int receptionistId, string phoneNo, string callDate, string callTime, 
        string callerName, string callerQuery, string callOutcome)
    {
        AddPhoneCallGeneralInquiryBO objAddPhoneCallGeneralInquiryBO = new AddPhoneCallGeneralInquiryBO();
        objAddPhoneCallGeneralInquiryBO.receptionistId = receptionistId;
        objAddPhoneCallGeneralInquiryBO.phoneNo = phoneNo;
        objAddPhoneCallGeneralInquiryBO.callDate = callDate;
        objAddPhoneCallGeneralInquiryBO.callTime = callTime;
        objAddPhoneCallGeneralInquiryBO.callerName = callerName;
        objAddPhoneCallGeneralInquiryBO.callerQuery = callerQuery;
        objAddPhoneCallGeneralInquiryBO.callOutcome = callOutcome;

        AddPhoneCallGeneralInquiryDL objAddPhoneCallGeneralInquiryDL = new AddPhoneCallGeneralInquiryDL();
        objAddPhoneCallGeneralInquiryDL.AddPhoneCallGeneralInquiry(objAddPhoneCallGeneralInquiryBO);
    }
}