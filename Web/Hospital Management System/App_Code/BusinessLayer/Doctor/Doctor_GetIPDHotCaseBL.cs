using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetIPDHotCaseBL
/// </summary>
public class Doctor_GetIPDHotCaseBL
{
    public DataSet Doctor_GetIPDHotCase(int doctorId)
	{
        Doctor_GetIPDHotCaseDL objDoctor_GetIPDHotCaseDL = new Doctor_GetIPDHotCaseDL();
        return objDoctor_GetIPDHotCaseDL.Doctor_GetIPDHotCase(doctorId);
	}
}