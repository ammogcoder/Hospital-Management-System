using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPhoneCallGeneralInquiryBL
/// </summary>
public class GetPhoneCallGeneralInquiryBL
{
	public DataSet GetPhoneCallGeneralInquiry(int empId)
	{
        GetPhoneCallGeneralInquiryDL objGetPhoneCallGeneralInquiryDL = new GetPhoneCallGeneralInquiryDL();
        return objGetPhoneCallGeneralInquiryDL.GetPhoneCallGeneralInquiry(empId);
	}
}