using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPhoneCallForwardBL
/// </summary>
public class GetPhoneCallForwardBL
{
    public DataSet GetPhoneCallForward(int empId)
	{
        GetPhoneCallForwardDL objGetPhoneCallForwardDL = new GetPhoneCallForwardDL();
        return objGetPhoneCallForwardDL.GetPhoneCallForward(empId);
	}
}