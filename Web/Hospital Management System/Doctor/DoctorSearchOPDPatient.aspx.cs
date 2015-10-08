using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorSearchOPDPatient : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string patientName = TextBox1.Text;
        Common_SearchOPDPatientBL objSearchOPDPatientBL = new Common_SearchOPDPatientBL();
        ds = objSearchOPDPatientBL.Common_SearchOPDPatient(patientName);
        if(ds.Tables[0].Rows.Count == 0)
        {
            Label1.Text = "No Patient Found";
            Label1.ForeColor = System.Drawing.Color.Red;
            GridView1.DataSource = null;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int patientId = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString());
        Response.Write(@"<script language=""javascript"">window.open('DoctorSelectOPDPatient.aspx?patientId=" + patientId + "', '_blank', 'height=650,width=1000,scrollbars')</script>");
    }
}