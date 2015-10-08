using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterEmployeeBL
/// </summary>
public class RegisterEmployeeBL
{
    public int RegisterEmployee(string empName, string empGender, string empDOB, string empAddress, string empCity, 
        string empPhoneNumber, string empEmailAddress, int empType, string empDateOfJoin, 
        string empDateOfLeave, int empBank, string empAccountNumber)
	{
        RegisterEmployeeBO objRegisterEmployeeBO = new RegisterEmployeeBO();
        objRegisterEmployeeBO.empName = empName;
        objRegisterEmployeeBO.empGender = empGender;
        objRegisterEmployeeBO.empDOB = empDOB;
        objRegisterEmployeeBO.empAddress = empAddress;
        objRegisterEmployeeBO.empPhoneNumber = empPhoneNumber;
        objRegisterEmployeeBO.empEmailAddress = empEmailAddress;
        objRegisterEmployeeBO.empType = empType;
        objRegisterEmployeeBO.empDateOfJoin = empDateOfJoin;
        objRegisterEmployeeBO.empDateOfLeave = empDateOfLeave;
        objRegisterEmployeeBO.empBank = empBank;
        objRegisterEmployeeBO.empAccountNumber = empAccountNumber;

        RegisterEmployeeDL objRegisterEmployeeDL = new RegisterEmployeeDL();
        return objRegisterEmployeeDL.RegisterEmployee(objRegisterEmployeeBO);
	}
}