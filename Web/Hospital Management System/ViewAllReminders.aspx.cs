using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistViewAllReminders : System.Web.UI.Page
{
    public static DataSet ds1 = new DataSet();
    public static DataSet ds2 = new DataSet();
    public static DataSet ds3 = new DataSet();
    public static DataSet ds4 = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            MultiView1.ActiveViewIndex = 0;
            Common_GetAllRemindersBL objGetAllRemindersBL = new Common_GetAllRemindersBL();
            string empType = Session["empType"].ToString();
            if(empType=="Receptionist")
                ds1 = objGetAllRemindersBL.Common_GetAllReminders(Convert.ToInt32(Session["receptionistId"].ToString()));
            else if(empType=="Doctor")
                ds1 = objGetAllRemindersBL.Common_GetAllReminders(Convert.ToInt32(Session["doctorId"].ToString()));
            GridView1.DataSource = ds1;
            GridView1.DataBind();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds1;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int filterType = Convert.ToInt32(RadioButtonList1.SelectedValue);
        string reminderDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string empType = Session["empType"].ToString();
        int empId=-1;
        if(empType=="Receptionist")
            empId = Convert.ToInt32(Session["receptionistId"].ToString());
        else if(empType == "Doctor")
            empId = Convert.ToInt32(Session["doctorId"].ToString());
        switch (filterType)
        {
            case 1:
                Common_FilterRemindersByOnDateBL objFilterRemindersByOnDateBL = new Common_FilterRemindersByOnDateBL();
                ds2 = objFilterRemindersByOnDateBL.Common_FilterRemindersByOnDate(reminderDate, empId);
                GridView2.DataSource = ds2;
                GridView2.DataBind();
                MultiView1.ActiveViewIndex = 1;
                break;

            case 2:
                Common_FilterRemindersByBeforeDateBL objFilterRemindersByBeforeDateBL = new Common_FilterRemindersByBeforeDateBL();
                ds3 = objFilterRemindersByBeforeDateBL.Common_FilterRemindersByBeforeDate(reminderDate, empId);
                GridView3.DataSource = ds3;
                GridView3.DataBind();
                MultiView1.ActiveViewIndex = 2;
                break;

            case 3:
                Common_FilterRemindersByAfterDateBL objFilterRemindersByAfterDateBL = new Common_FilterRemindersByAfterDateBL();
                ds4 = objFilterRemindersByAfterDateBL.Common_FilterRemindersByAfterDate(reminderDate, empId);
                GridView4.DataSource = ds4;
                GridView4.DataBind();
                MultiView1.ActiveViewIndex = 3;
                break;

            case 4:
                Common_GetAllRemindersBL objGetAllRemindersBL = new Common_GetAllRemindersBL();
                ds1 = objGetAllRemindersBL.Common_GetAllReminders(Convert.ToInt32(Session["empId"].ToString()));
                GridView1.DataSource = ds1;
                GridView1.DataBind();
                MultiView1.ActiveViewIndex = 0;
                break;
        }
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        GridView2.DataSource = ds2;
        GridView2.DataBind();
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView3.PageIndex = e.NewPageIndex;
        GridView3.DataSource = ds3;
        GridView3.DataBind();
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView4_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView4.PageIndex = e.NewPageIndex;
        GridView4.DataSource = ds4;
        GridView4.DataBind();
    }
    protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        int filterType = Convert.ToInt32(RadioButtonList1.SelectedValue);
        int empId = Convert.ToInt32(Session["empId"].ToString());
        switch (filterType)
        {
            case 1:
                //int reminderId=ds2.Tables[0].Rows[GridView2.SelectedIndex]
                break;
        }
    }
}