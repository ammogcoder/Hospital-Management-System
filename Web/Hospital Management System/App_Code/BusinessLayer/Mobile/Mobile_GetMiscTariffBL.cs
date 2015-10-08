using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetMiscTariffBL
/// </summary>
public class Mobile_GetMiscTariffBL
{
	public DataSet Mobile_GetMiscTariff()
	{
        Mobile_GetMiscTariffDL objMobile_GetMiscTariffDL = new Mobile_GetMiscTariffDL();
        return objMobile_GetMiscTariffDL.Mobile_GetMiscTariff();
	}
}