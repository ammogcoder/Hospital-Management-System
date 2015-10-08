using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for SearchEmployeeByNameBL
/// </summary>
public class Common_SearchEmployeeByNameBL
{
	public DataSet Common_SearchEmployeeByName(string empName)
	{
        SearchEmployeeByNameDL objSearchEmployeeByNameDL = new SearchEmployeeByNameDL();
        return objSearchEmployeeByNameDL.SearchEmployeeByName(empName);
	}
}