using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Mobile_GetBodyPartsBL
/// </summary>
public class Mobile_GetBodyPartsBL
{
	public DataSet Mobile_GetBodyParts()
	{
        Mobile_GetBodyPartsDL objMobile_GetBodyPartsDL = new Mobile_GetBodyPartsDL();
        return objMobile_GetBodyPartsDL.Mobile_GetBodyParts();
	}
}