using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetPresentEmployeesBL
/// </summary>
public class Common_GetPresentEmployeesBL
{
	public DataSet Common_GetPresentEmployees()
	{
        GetPresentEmployeesDL objGetPresentEmployeesDL = new GetPresentEmployeesDL();
        return objGetPresentEmployeesDL.GetPresentEmployees();
	}
}