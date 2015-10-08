using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterMessagePhoneCallBL
/// </summary>
public class FilterMessagePhoneCallBL
{
    public DataSet FilterMessagePhoneCall(int empId, string fromDate, string toDate)
	{
        FilterPhoneCallBO objFilterPhoneCallBO = new FilterPhoneCallBO();
        objFilterPhoneCallBO.empId = empId;
        objFilterPhoneCallBO.fromDate = fromDate;
        objFilterPhoneCallBO.toDate = toDate;

        FilterMessagePhoneCallDL objFilterMessagePhoneCallDL = new FilterMessagePhoneCallDL();
        return objFilterMessagePhoneCallDL.FilterMessagePhoneCall(objFilterPhoneCallBO);
	}
}