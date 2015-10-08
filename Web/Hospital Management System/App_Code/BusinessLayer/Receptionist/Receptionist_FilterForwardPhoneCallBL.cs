using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterForwardPhoneCallBL
/// </summary>
public class FilterForwardPhoneCallBL
{
    public DataSet FilterForwardPhoneCall(int empId, string fromDate, string toDate)
	{
        FilterPhoneCallBO objFilterPhoneCallBO = new FilterPhoneCallBO();
        objFilterPhoneCallBO.empId = empId;
        objFilterPhoneCallBO.fromDate = fromDate;
        objFilterPhoneCallBO.toDate = toDate;

        FilterForwardPhoneCallDL objFilterForwardPhoneCallDL = new FilterForwardPhoneCallDL();
        return objFilterForwardPhoneCallDL.FilterForwardPhoneCall(objFilterPhoneCallBO);
	}
}