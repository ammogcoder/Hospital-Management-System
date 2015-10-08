using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AddWardEntryBL
/// </summary>
public class AddWardEntryBL
{
    public void AddWardEntry(int wardId, int wardNumber, int patientId, int caseId)
	{
        AddWardEntryBO objAddWardEntryBO = new AddWardEntryBO();
        objAddWardEntryBO.wardId = wardId;
        objAddWardEntryBO.wardNumber = wardNumber;
        objAddWardEntryBO.patientId = patientId;
        objAddWardEntryBO.caseId = caseId;

        AddWardEntryDL objAddWardEntryDL = new AddWardEntryDL();
        objAddWardEntryDL.AddWardEntry(objAddWardEntryBO);
	}
}