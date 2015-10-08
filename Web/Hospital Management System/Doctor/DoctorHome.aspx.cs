using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        e.Cell.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#CC33FF'");
        e.Cell.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        int doctorId = Convert.ToInt32(Session["doctorId"].ToString());
        Doctor_GetCalendarAppointmentsBL objDoctor_GetCalendarAppointmentsBL = new Doctor_GetCalendarAppointmentsBL();
        DataSet ds = objDoctor_GetCalendarAppointmentsBL.Doctor_GetCalendarAppointments(doctorId);
        for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            int appointmentCount = Convert.ToInt32(ds.Tables[0].Rows[i]["APPOINTMENT_COUNT"].ToString());
            string appointmentDate = ds.Tables[0].Rows[i]["APPOINTMENT_DATE"].ToString();
            DateTime dt = Convert.ToDateTime(appointmentDate);
            string url = "DoctorViewAppointmentsByDate.aspx?date=" + e.Day.Date.ToString();
            HyperLink hyperlink = new HyperLink();
            hyperlink.ID = "hyperlink";
            hyperlink.Text = "<br /><b>" + appointmentCount + " Appointments</b>";
            hyperlink.Target = "_blank";
            hyperlink.NavigateUrl = "javascript:void(0)";
            hyperlink.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=600,scrollbars');");
            hyperlink.ForeColor = System.Drawing.Color.Yellow;
            if(e.Day.Date == dt)
            {
                e.Cell.Controls.Add(hyperlink);
            }
        }

        int empId = Convert.ToInt32(Session["doctorId"].ToString());
        Common_GetReminderBL objGetReminderBL = new Common_GetReminderBL();
        DataSet ds1 = objGetReminderBL.Common_GetReminder(empId);
        for(int i = 0; i < ds1.Tables[0].Rows.Count; i++)
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
            if(e.Day.Date == dt)
            {
                e.Cell.Controls.Add(hyperlink);
            }
        }
    }
}