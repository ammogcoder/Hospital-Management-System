using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChangePrimaryPhoneNumberBL
/// </summary>
public class Common_ChangePrimaryPhoneNumberBL
{
    public void Common_ChangePrimaryPhoneNumber(int empId, string primaryPhoneNumber)
	{
        ChangePrimaryPhoneNumberDL objChangePrimaryPhoneNumberDL = new ChangePrimaryPhoneNumberDL();
        objChangePrimaryPhoneNumberDL.ChangePrimaryPhoneNumber(empId, primaryPhoneNumber);
	}
}