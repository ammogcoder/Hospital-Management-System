using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistViewCalendarReminder : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        string empType = Session["empType"].ToString();
        int empId = -1;
        if(empType == "Receptionist")
            empId = Convert.ToInt32(Session["receptionistId"].ToString());
        else if(empType == "Doctor")
            empId = Convert.ToInt32(Session["doctorId"].ToString());
        DateTime dt = Convert.ToDateTime(Request.QueryString["date"].ToString());
        Label1.Text = dt.Date.ToShortDateString();
        string date = Request.QueryString["date"].ToString();
        Common_GetCalendarReminderInfoBL objGetCalendarReminderInfoBL = new Common_GetCalendarReminderInfoBL();
        ds = objGetCalendarReminderInfoBL.Common_GetCalendarReminderInfo(DateTime.ParseExact((Convert.ToDateTime(date)).ToString("dd-MM-yyyy"), "dd/MM/yyyy", System.Globalization.CultureInfo.InstalledUICulture).ToString(), empId);
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
        int reminderId = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString());
        Common_DeleteReminderBL objCommon_DeleteReminderBL = new Common_DeleteReminderBL();
        objCommon_DeleteReminderBL.Common_DeleteReminder(reminderId);
        Label2.Visible = true;
        Response.Redirect("../ReceptionistViewCalendarReminder.aspx?date=" + Request.QueryString["date"].ToString());
    }
}