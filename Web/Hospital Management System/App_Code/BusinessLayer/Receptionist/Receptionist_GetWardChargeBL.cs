using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetWardChargeBL
/// </summary>
public class GetWardChargeBL
{
	public DataSet GetWardCharge()
	{
        GetWardChargeDL objGetWardChargeDL = new GetWardChargeDL();
        return objGetWardChargeDL.GetWardCharge();
	}
}