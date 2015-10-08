using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewIPDObservationReportMedicine : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Common_EncryptDecryptBL objCommon_EncryptDecryptBL = new Common_EncryptDecryptBL();
            int ipdObservationReportId = Convert.ToInt32(objCommon_EncryptDecryptBL.Decrypt(Request.QueryString["ipdObservationReportId"].ToString()));
            string ipdObservationId = objCommon_EncryptDecryptBL.Decrypt(Request.QueryString["ipdObservationId"].ToString());
            Doctor_GetIPDReportMedicineBL objDoctor_GetIPDReportMedicineBL = new Doctor_GetIPDReportMedicineBL();
            ds = objDoctor_GetIPDReportMedicineBL.Doctor_GetIPDReportMedicine(ipdObservationReportId, ipdObservationId);
            if(ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
                Label1.Visible = true;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
}