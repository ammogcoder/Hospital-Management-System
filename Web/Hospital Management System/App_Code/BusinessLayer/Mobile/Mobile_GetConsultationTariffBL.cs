using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetConsultationTariffBL
/// </summary>
public class Mobile_GetConsultationTariffBL
{
	public DataSet Mobile_GetConsultationTariff()
	{
        Mobile_GetConsultationTariffDL objMobile_GetConsultationTariffDL = new Mobile_GetConsultationTariffDL();
        return objMobile_GetConsultationTariffDL.Mobile_GetConsultationTariff();
	}
}