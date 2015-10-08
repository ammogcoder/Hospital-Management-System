using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mobile_RequestPasswordBL
/// </summary>
public class Mobile_RequestPasswordBL
{
    public void Mobile_RequestPassword(int patientId, string patientPassword)
	{
        Mobile_RequestPasswordDL objMobile_RequestPasswordDL = new Mobile_RequestPasswordDL();
        objMobile_RequestPasswordDL.Mobile_RequestPassword(patientId, patientPassword);
	}
}