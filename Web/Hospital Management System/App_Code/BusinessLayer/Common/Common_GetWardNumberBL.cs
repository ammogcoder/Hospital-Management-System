using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetWardNumberBL
/// </summary>
public class GetWardNumberBL
{
	public DataSet GetWardNumber(int wardId)
	{
        GetWardNumberDL objGetWardNumberDL = new GetWardNumberDL();
        return objGetWardNumberDL.GetWardNumber(wardId);
	}
}