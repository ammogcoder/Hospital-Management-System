using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for GetAccountInfoBL
/// </summary>
public class Common_GetAccountInfoBL
{
	public DataSet Common_GetAccountInfo(int empId)
	{
        GetAccountInfoDL objGetAccountInfoDL = new GetAccountInfoDL();
        return objGetAccountInfoDL.GetAccountInfo(empId);
	}
}