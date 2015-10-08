using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetInboxBL
/// </summary>
public class Common_GetInboxBL
{
	public DataSet Common_GetInbox(int empId)
	{
        GetInboxDL objGetInboxDL = new GetInboxDL();
        return objGetInboxDL.GetInbox(empId);
	}
}