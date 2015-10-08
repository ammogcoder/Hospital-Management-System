using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminHomeMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.DataBind();
        if(Session["receptionistId"] == null)
            Response.Redirect("ReceptionistLogin.aspx");
        int receptionistId = Convert.ToInt32(Session["receptionistId"].ToString());
        Common_EmployeeNameBL objEmployeeNameBL = new Common_EmployeeNameBL();
        string empName = objEmployeeNameBL.Common_EmployeeName(receptionistId);
        Label1.Text = "Welcome, " + empName;
        Label3.Text = "Last Login: " + Session["receptionistLastLogin"].ToString();
    }
}
