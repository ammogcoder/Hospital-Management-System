using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for GetMedicalTestChargesBL
/// </summary>
public class GetMedicalTestChargesBL
{
	public DataSet GetMedicalTestCharges()
	{
        GetMedicalTestChargesDL objGetMedicalTestChargesDL = new GetMedicalTestChargesDL();
        return objGetMedicalTestChargesDL.GetMedicalTestCharges();
	}
}