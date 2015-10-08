using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for DoctorByDepartmentBL
/// </summary>
public class Common_DoctorByDepartmentBL
{
	public DataSet Common_DoctorByDepartment(int departmentId)
	{
        DoctorByDepartmentDL objDoctorByDepartmentDL = new DoctorByDepartmentDL();
        return objDoctorByDepartmentDL.DoctorByDepartment(departmentId);
	}
}