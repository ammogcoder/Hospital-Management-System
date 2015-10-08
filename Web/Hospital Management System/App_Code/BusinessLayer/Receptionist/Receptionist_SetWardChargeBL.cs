using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SetWardChargeBL
/// </summary>
public class SetWardChargeBL
{
    public void SetWardCharge(string suiteWardCharge, string deluxeWardCharge, string specialAcWardCharge, string semiWardPrivate, string generalWardCharge)
	{
        SetWardChargeBO objSetWardChargeBO = new SetWardChargeBO();
        objSetWardChargeBO.suiteWardCharge = suiteWardCharge;
        objSetWardChargeBO.deluxeWardCharge = deluxeWardCharge;
        objSetWardChargeBO.specialAcWardCharge = specialAcWardCharge;
        objSetWardChargeBO.semiWardPrivate = semiWardPrivate;
        objSetWardChargeBO.generalWardCharge = generalWardCharge;

        SetWardChargeDL objSetWardChargeDL = new SetWardChargeDL();
        objSetWardChargeDL.SetWardCharge(objSetWardChargeBO);
	}
}