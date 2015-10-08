using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetAllDoctorsBL
/// </summary>
public class Common_GetAllDoctorsBL
{
	public DataSet Common_GetAllDoctors()
	{
        GetAllDoctorsDL objGetAllDoctorsDL = new GetAllDoctorsDL();
        return objGetAllDoctorsDL.GetAllDoctors();
	}
}