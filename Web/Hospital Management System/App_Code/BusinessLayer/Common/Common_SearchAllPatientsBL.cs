using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Common_SearchAllPatientsBL
/// </summary>
public class Common_SearchAllPatientsBL
{
    public DataSet Common_SearchAllPatients(string patientName)
	{
        Common_SearchAllPatientsDL objCommon_SearchAllPatientsDL = new Common_SearchAllPatientsDL();
        return objCommon_SearchAllPatientsDL.Common_SearchAllPatients(patientName);
	}
}