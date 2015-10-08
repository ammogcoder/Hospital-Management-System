using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPhoneCallEmergencyBL
/// </summary>
public class GetPhoneCallEmergencyBL
{
    public DataSet GetPhoneCallEmergency(int empId)
	{
        GetPhoneCallEmergencyDL objGetPhoneCallEmergencyDL = new GetPhoneCallEmergencyDL();
        return objGetPhoneCallEmergencyDL.GetPhoneCallEmergency(empId);
	}
}