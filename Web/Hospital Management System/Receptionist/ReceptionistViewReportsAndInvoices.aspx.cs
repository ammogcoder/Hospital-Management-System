using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class Receptionist_ReceptionistViewReportsAndInvoices : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
 
    protected void Page_Load(object sender, EventArgs e)
    {

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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string invoiceId = ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();
        FileStream fs = new FileStream(System.Web.HttpContext.Current.Server.MapPath("../Invoice/Appointments/" + invoiceId + ".pdf"), FileMode.Open, FileAccess.Read);
        byte[] ar = new byte[(int)fs.Length];
        fs.Read(ar, 0, (int)fs.Length);
        fs.Close();

        Response.AddHeader("content-disposition", "attachment;filename=AppointmentInvoice.pdf");
        Response.ContentType = "application/octectstream";
        Response.BinaryWrite(ar);
        Response.End();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch(Convert.ToInt32(DropDownList1.SelectedValue))
        {
            case 1:
                GetAppointmentInvoiceBL objGetAppointmentInvoiceBL = new GetAppointmentInvoiceBL();
                ds = objGetAppointmentInvoiceBL.GetAppointmentInvoice();
                GridView1.DataSource = ds;
                GridView1.DataBind();
                MultiView1.ActiveViewIndex = 0;
                break;

            case 2:
                GetOPDMedicalTestRegistrationInvoiceBL objGetIPDMedicalTestRegistrationInvoiceBL = new GetOPDMedicalTestRegistrationInvoiceBL();
                ds = objGetIPDMedicalTestRegistrationInvoiceBL.GetOPDMedicalTestRegistrationInvoice();
                GridView2.DataSource = ds;
                GridView2.DataBind();
                MultiView1.ActiveViewIndex = 1;
                break;

            case 3:
                GetIPDRegistrationReportBL objGetIPDRegistrationReportBL = new GetIPDRegistrationReportBL();
                ds = objGetIPDRegistrationReportBL.GetIPDRegistrationReport();
                GridView3.DataSource = ds;
                GridView3.DataBind();
                MultiView1.ActiveViewIndex = 2;
                break;
        }
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string invoiceId = ds.Tables[0].Rows[GridView2.SelectedIndex][0].ToString();
        FileStream fs = new FileStream(System.Web.HttpContext.Current.Server.MapPath("../Invoice/OPDMedicalTestRegistration/" + invoiceId + ".pdf"), FileMode.Open, FileAccess.Read);
        byte[] ar = new byte[(int)fs.Length];
        fs.Read(ar, 0, (int)fs.Length);
        fs.Close();

        Response.AddHeader("content-disposition", "attachment;filename=OPDMedicalTestRegistrationInvoice.pdf");
        Response.ContentType = "application/octectstream";
        Response.BinaryWrite(ar);
        Response.End();
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        string reportId = ds.Tables[0].Rows[GridView3.SelectedIndex][0].ToString();
        FileStream fs = new FileStream(System.Web.HttpContext.Current.Server.MapPath("../Reports/IPDRegistration/" + reportId + ".pdf"), FileMode.Open, FileAccess.Read);
        byte[] ar = new byte[(int)fs.Length];
        fs.Read(ar, 0, (int)fs.Length);
        fs.Close();

        Response.AddHeader("content-disposition", "attachment;filename=IPDRegistrationReport.pdf");
        Response.ContentType = "application/octectstream";
        Response.BinaryWrite(ar);
        Response.End();
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        GridView3.DataSource = ds;
        GridView3.DataBind();
    }
}