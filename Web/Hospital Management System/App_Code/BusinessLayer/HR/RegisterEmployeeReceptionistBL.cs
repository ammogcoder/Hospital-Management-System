using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RegisterEmployeeReceptionist
/// </summary>
public class RegisterEmployeeReceptionistBL
{
	public int RegisterEmployeeReceptionist(int receptionistEmpId, string marks10, string marks12)
	{
        RegisterEmployeeReceptionistBO objRegisterEmployeeReceptionistBO = new RegisterEmployeeReceptionistBO();
        objRegisterEmployeeReceptionistBO.receptionistEmpId = receptionistEmpId;
        objRegisterEmployeeReceptionistBO.marks10 = marks10;
        objRegisterEmployeeReceptionistBO.marks12 = marks12;

        RegisterEmployeeReceptionistDL objRegisterEmployeeReceptionistDL = new RegisterEmployeeReceptionistDL();
        return objRegisterEmployeeReceptionistDL.RegisterEmployeeReceptionist(objRegisterEmployeeReceptionistBO);
	}
}