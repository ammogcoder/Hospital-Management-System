using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChangePasswordBL
/// </summary>
public class Common_ChangePasswordBL
{
	public void Common_ChangePassword(int empId, string password)
	{
        ChangePasswordDL objChangePasswordDL = new ChangePasswordDL();
        objChangePasswordDL.ChangePassword(empId, password);
	}
}