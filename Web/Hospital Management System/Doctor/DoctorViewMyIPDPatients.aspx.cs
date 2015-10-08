using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewMyIPDPatients : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    public static int doctorId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            doctorId = Convert.ToInt32(Session["doctorId"].ToString());
            GetCurrentIPDPatients();
        }
    }
    private void GetCurrentIPDPatients()
    {
        Doctor_GetCurrentIPDPatientsBL objDoctor_GetCurrentIPDPatientsBL = new Doctor_GetCurrentIPDPatientsBL();
        ds=objDoctor_GetCurrentIPDPatientsBL.Doctor_GetCurrentIPDPatients(Convert.ToInt32(Session["doctorId"].ToString()));
        if(ds.Tables[0].Rows.Count != 0)
        {
            GridView1.DataSource=ds;
            GridView1.DataBind();
        }
        else
            Label1.Visible=true;
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["patientId"] = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString());
        string url = "DoctorViewIPDPatientDetails.aspx";
        string script="window.open('" + url + "', '_blank', 'width=550, height=650');";
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
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ipdPatientType = Convert.ToInt32(RadioButtonList1.SelectedValue);
        switch(ipdPatientType)
        {
            case 1:
                resetGridView(2);
                resetGridView(3);
                resetGridView(4);
                GetCurrentIPDPatients();
                break;
            case 2:
                resetGridView(1);
                resetGridView(2);
                resetGridView(3);
                Doctor_GetNewIPDPatientsBL objDoctor_GetNewIPDPatientsBL = new Doctor_GetNewIPDPatientsBL();
                ds = objDoctor_GetNewIPDPatientsBL.Doctor_GetNewIPDPatients(doctorId);
                GridView3.DataSource = ds;
                GridView3.DataBind();
                break;
        }
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        GridView3.DataSource = ds;
        GridView3.DataBind();
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    private void resetGridView(int gridViewNumber)
    {
        switch(gridViewNumber)
        {
            case 1:
                GridView1.DataSource = null;
                GridView1.DataBind();
                break;
            case 2:
                GridView2.DataSource = null;
                GridView2.DataBind();
                break;
            case 3:
                GridView3.DataSource = null;
                GridView3.DataBind();
                break;
            /*case 4:
                GridView4.DataSource = null;
                GridView4.DataBind();
                break;*/
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int ipdPatientType = Convert.ToInt32(RadioButtonList1.SelectedValue);
        switch(ipdPatientType)
        {
            case 1:
                resetGridView(2);
                resetGridView(3);
                resetGridView(4);
                break;
        }
    }
}