using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doctor_DoctorViewTodaysAppointments : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string today = DateTime.Today.Date.ToShortDateString();
        Response.Redirect("DoctorViewAppointmentsByDate.aspx?date=" + today);
    }
}