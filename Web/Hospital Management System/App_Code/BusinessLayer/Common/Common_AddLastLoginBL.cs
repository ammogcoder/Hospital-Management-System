using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddLastLoginBL
/// </summary>
public class Common_AddLastLoginBL
{
	public void Common_AddLastLogin(int empId)
	{
        AddLastLoginBO objAddLastLoginBO = new AddLastLoginBO();
        objAddLastLoginBO.empId = empId;
        AddLastLoginDL objAddLastLoginDL = new AddLastLoginDL();
        objAddLastLoginDL.AddLastLogin(objAddLastLoginBO);
	}
}