using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterGeneralInquiryPhoneCallBL
/// </summary>
public class FilterGeneralInquiryPhoneCallBL
{
	public DataSet FilterGeneralInquiryPhoneCall(int empId, string fromDate, string toDate)
	{
        FilterPhoneCallBO objFilterPhoneCallBO = new FilterPhoneCallBO();
        objFilterPhoneCallBO.empId = empId;
        objFilterPhoneCallBO.fromDate = fromDate;
        objFilterPhoneCallBO.toDate = toDate;

        FilterGeneralInquiryPhoneCallDL objFilterGeneralInquiryPhoneCallDL = new FilterGeneralInquiryPhoneCallDL();
        return objFilterGeneralInquiryPhoneCallDL.FilterGeneralInquiryPhoneCall(objFilterPhoneCallBO);
	}
}