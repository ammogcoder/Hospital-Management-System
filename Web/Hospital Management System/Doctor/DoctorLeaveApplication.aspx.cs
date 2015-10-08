using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doctor_DoctorLeaveApplication : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int doctorId = Convert.ToInt32(Session["doctorId"].ToString());
        string leaveFromDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string leaveFromTime = TextBox2.Text; 
        string leaveToDate = DateTime.ParseExact(TextBox6.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string leaveToTime = TextBox7.Text;
        string leaveReason = TextBox4.Text;

        DateTime dt1 = Convert.ToDateTime(leaveFromDate);
        DateTime dt2 = Convert.ToDateTime(leaveToDate);
        if(DateTime.Compare(dt1, dt2) > 0)
        {
            Label6.Text = "Leave from date cannot be later than leave to date";
            Label6.ForeColor = System.Drawing.Color.Red;
            Label6.BackColor = System.Drawing.Color.Snow;
        }
        else
        {
            Doctor_LeaveApplicationBL objDoctor_LeaveApplicationBL = new Doctor_LeaveApplicationBL();
            objDoctor_LeaveApplicationBL.Doctor_LeaveApplication(doctorId, leaveFromDate, leaveFromTime, leaveToDate, leaveToTime, leaveReason);
            Label6.Text = "Leave application submitted";
            Label6.ForeColor = System.Drawing.Color.Black;
            Label6.BackColor = System.Drawing.Color.Yellow;
            reset();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        reset();
    }
    protected void reset()
    {
        TextBox1.Text = TextBox2.Text = TextBox4.Text = TextBox6.Text = TextBox7.Text = "";
    }
}