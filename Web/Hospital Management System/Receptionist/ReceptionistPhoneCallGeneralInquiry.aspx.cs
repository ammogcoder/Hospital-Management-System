using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Receptionist_ReceptionistPhoneCallGeneralInquiry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int receptionistId = Convert.ToInt32(Session["receptionistId"].ToString());
        string phoneNo = TextBox5.Text;
        string callDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string callTime = TextBox2.Text;
        string callerName = TextBox3.Text;
        string callerQuery = TextBox4.Text;
        string callOutCome = TextBox6.Text;

        AddPhoneCallGeneralInquiryBL objAddPhoneCallGeneralInquiryBL = new AddPhoneCallGeneralInquiryBL();
        objAddPhoneCallGeneralInquiryBL.AddPhoneCallGeneralInquiry(receptionistId, phoneNo, callDate, callTime, callerName, callerQuery, callOutCome);
        Label5.Text = "Phone Call Record Saved";
        Label5.BackColor = System.Drawing.Color.Yellow;

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        Label5.Text = "";
    }
}