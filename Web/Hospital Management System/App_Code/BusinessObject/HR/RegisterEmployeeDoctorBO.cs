using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterEmployeeDoctorBO
/// </summary>
public class RegisterEmployeeDoctorBO
{
    public int doctorEmpId { get; set; }
    public string doctorLicenseNumber { get; set; }
    public int doctorDepartment { get; set; }
    public int doctorDegree { get; set; }
    public string doctorUniversityName { get; set; }
    public string doctorUniversityCity { get; set; }
    public string doctorUniversityState { get; set; }
    public string doctorUniversityCountry { get; set; }
    public int doctorExperience { get; set; }

}