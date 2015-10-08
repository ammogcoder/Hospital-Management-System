using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Receptionist_ReceptionistAddReminder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string empType = Session["empType"].ToString();
        int empId = -1;
        if(empType == "Receptionist")
            empId = Convert.ToInt32(Session["receptionistId"].ToString());
        else if(empType == "Doctor")
            empId = Convert.ToInt32(Session["doctorId"].ToString());
        string reminderDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string reminderTitle = TextBox2.Text;
        string reminderDetails = TextBox3.Text;

        Common_AddReminderBL objAddReminderBL = new Common_AddReminderBL();
        objAddReminderBL.Common_AddReminder(empId, reminderTitle, reminderDetails, reminderDate);
        Label1.Visible = true;
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
}