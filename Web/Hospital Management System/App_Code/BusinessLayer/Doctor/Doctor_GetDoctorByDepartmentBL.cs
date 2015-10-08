using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Doctor_GetDoctorByDepartmentBL
/// </summary>
public class Doctor_GetDoctorByDepartmentBL
{
    public DataSet Doctor_GetDoctorByDepartment(int departmentId, int empId)
	{
        Doctor_GetDoctorByDepartmentDL objDoctor_GetDoctorByDepartmentDL = new Doctor_GetDoctorByDepartmentDL();
        return objDoctor_GetDoctorByDepartmentDL.Doctor_GetDoctorByDepartment(departmentId, empId);
	}
}