using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GetSMSTemplateBL
/// </summary>
public class Common_GetSMSTemplateBL
{
    public string Common_GetSMSTemplate(int templateId)
	{
        GetSMSTemplateDL objGetSMSTemplateDL = new GetSMSTemplateDL();
        return objGetSMSTemplateDL.GetSMSTemplate(templateId);
	}
}