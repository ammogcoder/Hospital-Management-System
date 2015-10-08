using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for SearchDoctorBL
/// </summary>
public class SearchDoctorBL
{
	public DataSet SearchDoctor(string doctorName)
	{
        SearchDoctorDL objSearchDoctorDL = new SearchDoctorDL();
        return objSearchDoctorDL.SearchDoctor(doctorName);
	}
}