using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for FilterEmergencyPhoneCallBL
/// </summary>
public class FilterEmergencyPhoneCallBL
{
    public DataSet FilterEmergencyPhoneCall(int empId, string fromDate, string toDate)
	{
        FilterPhoneCallBO objFilterPhoneCallBO = new FilterPhoneCallBO();
        objFilterPhoneCallBO.empId = empId;
        objFilterPhoneCallBO.fromDate = fromDate;
        objFilterPhoneCallBO.toDate = toDate;

        FilterEmergencyPhoneCallDL objFilterEmergencyPhoneCallDL = new FilterEmergencyPhoneCallDL();
        return objFilterEmergencyPhoneCallDL.FilterEmergencyPhoneCall(objFilterPhoneCallBO);
	}
}