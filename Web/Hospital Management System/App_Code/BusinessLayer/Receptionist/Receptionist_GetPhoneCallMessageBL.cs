using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPhoneCallMessageBL
/// </summary>
public class GetPhoneCallMessageBL
{
    public DataSet GetPhoneCallMessage(int empId)
	{
        GetPhoneCallMessageDL objGetPhoneCallMessageDL = new GetPhoneCallMessageDL();
        return objGetPhoneCallMessageDL.GetPhoneCallMessage(empId);
	}
}