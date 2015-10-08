using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoginBL
/// </summary>
public class Common_LoginBL
{
	public void Common_InsertTemporaryLogin(int empId, string empUsername, string empPassword)
	{
        LoginBO objLoginBO = new LoginBO();
        objLoginBO.empId = empId;
        objLoginBO.empUsername = empUsername;
        objLoginBO.empPassword = empPassword;

        LoginDL objLoginDL = new LoginDL();
        objLoginDL.InsertTemporaryLogin(objLoginBO);
	}

    public int Common_Login(string empUsername, string empPassword)
    {

        LoginBO objLoginBO = new LoginBO();
        objLoginBO.empUsername = empUsername;
        objLoginBO.empPassword = empPassword;

        LoginDL objLoginDL = new LoginDL();
        return objLoginDL.Login(objLoginBO);
    }
}