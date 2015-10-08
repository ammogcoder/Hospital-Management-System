using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewIPDAllIPDObservationReports : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    public static int patientId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            patientId = Convert.ToInt32(Session["patientId"].ToString());
            Doctor_GetAllIPDObservationReportsBL objDoctor_GetAllIPDObservationReportsBL = new Doctor_GetAllIPDObservationReportsBL();
            ds = objDoctor_GetAllIPDObservationReportsBL.Doctor_GetAllIPDObservationReports(patientId);
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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Common_EncryptDecryptBL objCommon_EncryptDecryptBL = new Common_EncryptDecryptBL();
        string ipdObservationReportId = objCommon_EncryptDecryptBL.Common_Encrypt(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString());
        string ipdObservationId = objCommon_EncryptDecryptBL.Common_Encrypt(ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString());
        string url = "DoctorViewIPDObservationReportMedicine.aspx?ipdObservationId=" + ipdObservationId + "&ipdObservationReportId=" + ipdObservationReportId;
        string script = "window.open('" + url + "', '_blank', 'width=1060, height=650');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", script, true); 
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