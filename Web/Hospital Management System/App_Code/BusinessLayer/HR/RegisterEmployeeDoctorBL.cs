using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterEmployeeDoctorBL
/// </summary>
public class RegisterEmployeeDoctorBL
{
    public void RegisterEmployeeDoctor(int doctorEmpId, string doctorLicenseNumber, 
        int doctorDepartment, int doctorDegree, string doctorUniversityName, 
        string doctorUniversityCity, string doctorUniversityState, string doctorUniversityCountry,
        int doctorExperience)
	{
        RegisterEmployeeDoctorBO objRegisterEmployeeDoctorBO = new RegisterEmployeeDoctorBO();
        objRegisterEmployeeDoctorBO.doctorEmpId = doctorEmpId;
        objRegisterEmployeeDoctorBO.doctorLicenseNumber = doctorLicenseNumber;
        objRegisterEmployeeDoctorBO.doctorDepartment = doctorDepartment;
        objRegisterEmployeeDoctorBO.doctorDegree = doctorDegree;
        objRegisterEmployeeDoctorBO.doctorUniversityName = doctorUniversityName;
        objRegisterEmployeeDoctorBO.doctorUniversityCity = doctorUniversityCity;
        objRegisterEmployeeDoctorBO.doctorUniversityState = doctorUniversityState;
        objRegisterEmployeeDoctorBO.doctorUniversityCountry = doctorUniversityCountry;
        objRegisterEmployeeDoctorBO.doctorExperience = doctorExperience;

        RegisterEmployeeDoctorDL objRegisterEmployeeDoctorDL = new RegisterEmployeeDoctorDL();
        objRegisterEmployeeDoctorDL.RegisterEmployeeDoctor(objRegisterEmployeeDoctorBO);
	}
}