using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChangeSecondaryPhoneNumberBL
/// </summary>
public class Common_ChangeSecondaryPhoneNumberBL
{
	public void Common_ChangeSecondaryPhoneNumber(int empId, string secondaryPhoneNumber)
	{
        ChangeSecondaryPhoneNumberDL objChangeSecondaryPhoneNumberDL = new ChangeSecondaryPhoneNumberDL();
        objChangeSecondaryPhoneNumberDL.ChangeSecondaryPhoneNumber(empId, secondaryPhoneNumber);
	}
}