using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.IO;

public partial class Receptionist_ReceptionistHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            Common_GetAllDoctorsBL objGetAllDoctorsBL = new Common_GetAllDoctorsBL();
            DropDownList1.DataSource = objGetAllDoctorsBL.Common_GetAllDoctors();
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataTextField = "DOCTOR_NAME";
            DropDownList1.Items.Add(new ListItem("All", "0"));
            DropDownList1.DataBind();
        }
    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        e.Cell.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#CC33FF'");
        e.Cell.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        if (Convert.ToInt32(DropDownList1.SelectedValue) == 0)
        {
            GetCalendarDoctorAppointmentsBL objGetCalendarDoctorAppointmentsBL = new GetCalendarDoctorAppointmentsBL();
            DataSet ds = objGetCalendarDoctorAppointmentsBL.GetCalendarDoctorAppointments();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int appointmentCount = Convert.ToInt32(ds.Tables[0].Rows[i]["APPOINTMENT_COUNT"].ToString());
                string appointmentDate = ds.Tables[0].Rows[i]["APPOINTMENT_DATE"].ToString();
                DateTime dt = Convert.ToDateTime(appointmentDate);
                string url = "ReceptionistViewCalendarAppointments.aspx?date=" + e.Day.Date.ToString();
                HyperLink hyperlink = new HyperLink();
                hyperlink.ID = "hyperlink";
                hyperlink.Text = "<br /><b>" + appointmentCount + " Appointments</b>";
                hyperlink.Target = "_blank";
                hyperlink.NavigateUrl = "javascript:void(0)";
                hyperlink.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=800,scrollbars');");
                hyperlink.ForeColor = System.Drawing.Color.Yellow;
                if (e.Day.Date == dt)
                {
                    e.Cell.Controls.Add(hyperlink);
                }
            }
        }
        else
        {
            Common_GetCalendarDoctorAppointmentsByIdBL objGetCalendarDoctorAppointmentsByIdBL = new Common_GetCalendarDoctorAppointmentsByIdBL();
            DataSet ds = objGetCalendarDoctorAppointmentsByIdBL.Common_GetCalendarDoctorAppointmentsById(Convert.ToInt32(DropDownList1.SelectedValue));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int appointmentCount = Convert.ToInt32(ds.Tables[0].Rows[i]["APPOINTMENT_COUNT"].ToString());
                string appointmentDate = ds.Tables[0].Rows[i]["APPOINTMENT_DATE"].ToString();
                DateTime dt = Convert.ToDateTime(appointmentDate);
                string url = "ReceptionistViewDoctorCalendarAppointments.aspx?date=" + e.Day.Date.ToString();
                HyperLink hyperlink = new HyperLink();
                hyperlink.ID = "hyperlink";
                hyperlink.Text = "<br /><b>" + appointmentCount + " Appointments</b>";
                hyperlink.Target = "_blank";
                hyperlink.NavigateUrl = "javascript:void(0)";
                hyperlink.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=800,scrollbars');");
                hyperlink.ForeColor = System.Drawing.Color.Yellow;
                if (e.Day.Date == dt)
                {
                    e.Cell.Controls.Add(hyperlink);
                }
            }
        }

        int empId = Convert.ToInt32(Session["receptionistId"].ToString());
        Common_GetReminderBL objGetReminderBL = new Common_GetReminderBL();
        DataSet ds1 = objGetReminderBL.Common_GetReminder(empId);
        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        {
            int reminderCount = Convert.ToInt32(ds1.Tables[0].Rows[i]["REMINDER_COUNT"].ToString());
            string reminderDate = ds1.Tables[0].Rows[i]["REMINDER_DATE"].ToString();
            DateTime dt = Convert.ToDateTime(reminderDate);
            HyperLink hyperlink = new HyperLink();
            hyperlink.ID = "hyperlink";
            hyperlink.Text = "<br /><b>" + reminderCount + " Reminder</b>";
            hyperlink.Target = "_blank";
            hyperlink.NavigateUrl = "javascript:void(0)";
            hyperlink.Attributes.Add("onclick", "javascript:window.open('" + "../ViewCalendarReminder.aspx?date=" + e.Day.Date.ToString() + "','','height=500,width=550,scrollbars');");
            hyperlink.ForeColor = System.Drawing.Color.Yellow;
            if (e.Day.Date == dt)
            {
                e.Cell.Controls.Add(hyperlink);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["doctorId"] = DropDownList1.SelectedValue;
    }
}