using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_RecepionistAccountInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        getAccountInfo();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        LinkButton1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        LinkButton1.Visible = true;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
        LinkButton2.Visible = false;
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
        LinkButton2.Visible = true;
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Panel3.Visible = true;
        LinkButton3.Visible = false;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Panel3.Visible = false;
        LinkButton3.Visible = true;
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        LinkButton4.Visible = false;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        LinkButton4.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string newPassword = TextBox3.Text;
        string currentPassword = TextBox1.Text;
        int empId = Convert.ToInt32(Session["empId"].ToString());
        if (Session["empPassword"].ToString() != currentPassword)
        {
            Label22.Text = "Incorrect Password";
            Label22.BackColor = System.Drawing.Color.Red;
        }
        else
        {
            Common_ChangePasswordBL objChangePasswordBL = new Common_ChangePasswordBL();
            objChangePasswordBL.Common_ChangePassword(empId, newPassword);
            Label22.Text = "Password Updated";
            Label22.BackColor = System.Drawing.Color.Yellow;
            Panel1.Visible = false;
            LinkButton1.Visible = true;
            getAccountInfo();
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        string primaryPhoneNumber = TextBox6.Text;
        int empId = Convert.ToInt32(Session["empId"].ToString());

        Common_ChangePrimaryPhoneNumberBL objChangePrimaryPhoneNumberBL = new Common_ChangePrimaryPhoneNumberBL();
        objChangePrimaryPhoneNumberBL.Common_ChangePrimaryPhoneNumber(empId, primaryPhoneNumber);
        Label22.Text = "Primary Phone Number Updated";
        Label22.BackColor = System.Drawing.Color.Yellow;
        Panel4.Visible = false;
        LinkButton2.Visible = true;
        getAccountInfo();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        string secondaryPhoneNumber = TextBox5.Text;
        int empId = Convert.ToInt32(Session["empId"].ToString());

        Common_ChangeSecondaryPhoneNumberBL objChangeSecondaryPhoneNumberBL = new Common_ChangeSecondaryPhoneNumberBL();
        objChangeSecondaryPhoneNumberBL.Common_ChangeSecondaryPhoneNumber(empId, secondaryPhoneNumber);
        Panel3.Visible = false;
        LinkButton3.Visible = true;
        if(LinkButton3.Text == "Update Secondary Phone Number")
            Label22.Text = "Secondary Phone Number Updated";
        else if(LinkButton3.Text == "Add Secondary Phone Number")
            Label22.Text = "Secondary Phone Number Added";
        Label22.BackColor = System.Drawing.Color.Yellow;
        getAccountInfo();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string emailAddress = TextBox4.Text;
        int empId = Convert.ToInt32(Session["empId"].ToString());

        Common_ChangeEmailAddressBL objChangeEmailAddressBL = new Common_ChangeEmailAddressBL();
        objChangeEmailAddressBL.Common_ChangeEmailAddress(empId, emailAddress);
        Panel2.Visible = false;
        LinkButton4.Visible = true;
        if(LinkButton4.Text == "Add Email Address")
            Label22.Text = "Email Address Added";
        else if (LinkButton4.Text == "Update Email Address")
            Label22.Text = "Email Address Updated";
        Label22.BackColor = System.Drawing.Color.Yellow;
        getAccountInfo();
    }

    protected void getAccountInfo()
    {
        int empId = Convert.ToInt32(Session["empId"].ToString());
        Common_GetAccountInfoBL objGetAccountInfoBL = new Common_GetAccountInfoBL();
        DataSet ds = objGetAccountInfoBL.Common_GetAccountInfo(empId);
        Label4.Text = ds.Tables[0].Rows[0]["EMPLOYEE_USERNAME"].ToString();
        string password = ds.Tables[0].Rows[0]["EMPLOYEE_PASSWORD"].ToString();
        string maskedPassword = "";
        for (int i = 0; i < password.Length; i++)
        {
            maskedPassword += "*";
        }
        Label5.Text = maskedPassword;
        Label6.Text = ds.Tables[0].Rows[0]["ACCOUNT_ACTIVATION_DATE_TIME"].ToString();
        Label9.Text = ds.Tables[0].Rows[0]["LAST_LOGIN_DATE_TIME"].ToString();
        Label11.Text = ds.Tables[0].Rows[0]["EMPLOYEE_PRIMARY_PHONE"].ToString();
        Label13.Text = ds.Tables[0].Rows[0]["EMPLOYEE_SECONDARY_PHONE"].ToString();
        Label15.Text = ds.Tables[0].Rows[0]["EMPLOYEE_EMAIL"].ToString();

        if (Label13.Text == "")
        {
            LinkButton3.Text = "Add Secondary Phone Number";
            Button5.Text = "Add Secondary Phone Number";
        }
        else if (Label13.Text != "")
        {
            LinkButton3.Text = "Update Secondary Phone Number";
            Button5.Text = "Update Secondary Phone Number";
        }
        if (Label15.Text == "")
        {
            LinkButton4.Text = "Add Email Address";
            Button3.Text = "Add Email Address";
        }
        else if (Label15.Text != "")
        {
            LinkButton4.Text = "Update Email Address";
            Button3.Text = "Update Email Address";
        }
    }
}