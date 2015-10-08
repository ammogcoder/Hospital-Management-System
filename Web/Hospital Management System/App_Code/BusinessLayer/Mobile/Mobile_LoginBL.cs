using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_LoginBL
/// </summary>
public class Mobile_LoginBL
{
    public DataSet Mobile_Login(string patientPhone, string patientPassword)
	{
        Mobile_LoginDL objMobile_LoginDL = new Mobile_LoginDL();
        return objMobile_LoginDL.Mobile_Login(patientPhone, patientPassword);
	}
}