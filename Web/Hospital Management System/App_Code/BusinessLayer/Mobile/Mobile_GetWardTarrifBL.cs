using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetWardTarrifBL
/// </summary>
public class Mobile_GetWardTarrifBL
{
	public DataSet Mobile_GetWardTarrif()
	{
        Mobile_GetWardTarrifDL objMobile_GetWardTarrifDL = new Mobile_GetWardTarrifDL();
        return objMobile_GetWardTarrifDL.Mobile_GetWardTarrif();
	}
}