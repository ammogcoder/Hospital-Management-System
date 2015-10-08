using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetDepartmentsBL
/// </summary>
public class Mobile_GetDepartmentsBL
{
	public DataSet Mobile_GetDepartments()
	{
        Mobile_GetDepartmentsDL objMobile_GetDepartmentsDL = new Mobile_GetDepartmentsDL();
        return objMobile_GetDepartmentsDL.Mobile_GetDepartments();
	}
}