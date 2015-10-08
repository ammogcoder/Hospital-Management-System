using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewIPDObservationHistoryDetails : System.Web.UI.Page
{
    public static DataSet ds1 = new DataSet();
    public static DataSet ds2 = new DataSet();
    public static DataSet ds3 = new DataSet();
    public static DataSet ds4 = new DataSet();
    public static string ipdObservationId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Common_EncryptDecryptBL objCommon_EncryptDecryptBL = new Common_EncryptDecryptBL();
            ipdObservationId = objCommon_EncryptDecryptBL.Decrypt(Request.QueryString["ipdObservationId"].ToString());
            
            Doctor_GetPatientDetailsByIPDObservationIDBL objDoctor_GetPatientDetailsByIPDObservationIDBL = new Doctor_GetPatientDetailsByIPDObservationIDBL();
            Label1.Text = objDoctor_GetPatientDetailsByIPDObservationIDBL.Doctor_GetPatientDetailsByIPDObservationID(ipdObservationId);

            Doctor_GetIPDObservationDetailsByIdBL objDoctor_GetIPDObservationDetailsByIdBL = new Doctor_GetIPDObservationDetailsByIdBL();
            ds1 = objDoctor_GetIPDObservationDetailsByIdBL.Doctor_GetIPDObservationDetailsById(ipdObservationId);
            Label2.Text = ds1.Tables[0].Rows[0]["OBSERVATION_DATE"].ToString();
            Label3.Text = ds1.Tables[0].Rows[0]["OBSERVATION_TIME"].ToString();
            Label4.Text = ds1.Tables[0].Rows[0]["PATIENT_GENERAL_HEALTH"].ToString();

            Doctor_GetIPDObservationReportBL objDoctor_GetIPDObservationReportBL = new Doctor_GetIPDObservationReportBL();
            ds2 = objDoctor_GetIPDObservationReportBL.Doctor_GetIPDObservationReport(ipdObservationId);
            GridView1.DataSource = ds2;
            GridView1.DataBind();

            Doctor_GetIPDObservationMedicineBL objDoctor_GetIPDObservationMedicineBL = new Doctor_GetIPDObservationMedicineBL();
            ds3 = objDoctor_GetIPDObservationMedicineBL.Doctor_GetIPDObservationMedicine(ipdObservationId);
            if(ds3.Tables[0].Rows.Count != 0)
            {
                GridView2.DataSource = ds3;
                GridView2.DataBind();
            }
            else
                Label5.Visible = true;

            Doctor_GetIPDObservationMedicalTestBL objDoctor_GetIPDObservationMedicalTestBL = new Doctor_GetIPDObservationMedicalTestBL();
            ds4 = objDoctor_GetIPDObservationMedicalTestBL.Doctor_GetIPDObservationMedicalTest(ipdObservationId);
            if(ds4.Tables[0].Rows.Count != 0)
            {
                GridView3.DataSource = ds4;
                GridView3.DataBind();
            }
            else
                Label6.Visible = true;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds2;
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
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = ds3;
        GridView2.DataBind();
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        GridView3.DataSource = ds4;
        GridView3.DataBind();
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
}