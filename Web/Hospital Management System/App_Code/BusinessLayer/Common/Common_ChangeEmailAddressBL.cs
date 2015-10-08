using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChangeEmailAddressBL
/// </summary>
public class Common_ChangeEmailAddressBL
{
	public void Common_ChangeEmailAddress(int empId, string emailAddress)
	{
        ChangeEmailAddressDL objChangeEmailAddressDL = new ChangeEmailAddressDL();
        objChangeEmailAddressDL.ChangeEmailAddress(empId, emailAddress);
	}
}