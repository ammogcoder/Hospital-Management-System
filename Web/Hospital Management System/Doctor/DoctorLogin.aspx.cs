using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class css_Doctor_DoctorLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string empUsername = TextBox1.Text;
        string empPassword = TextBox2.Text;

        Common_LoginBL objLoginBL = new Common_LoginBL();
        int empId = objLoginBL.Common_Login(empUsername, empPassword);
        if (empId == 0)
        {
            Label1.Text = "Invalid Username/Password";
            Label1.Visible = true;
            Label1.ForeColor = System.Drawing.Color.Red;
            TextBox1.BackColor = System.Drawing.Color.Pink;
            TextBox2.BackColor = System.Drawing.Color.Pink;
        }
        else
        {
            Session["empType"] = "Doctor";
            Session["doctorId"] = empId;
            Session["doctorUsername"] = empUsername;
            Session["doctorPassword"] = empPassword;
            Common_GetLastLoginBL objCommon_GetLastLoginBL = new Common_GetLastLoginBL();
            Session["doctortLastLogin"] = objCommon_GetLastLoginBL.Common_GetLastLogin(empId);
            Common_AddLastLoginBL objAddLastLoginBL = new Common_AddLastLoginBL();
            objAddLastLoginBL.Common_AddLastLogin(empId);
            Session.Timeout = 24 * 60;
            Response.Redirect("DoctorHome.aspx");
        }
    }
}