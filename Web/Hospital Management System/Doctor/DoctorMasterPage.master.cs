using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doctor_DoctorMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.DataBind();
        if(Session["doctorId"] == null)
            Response.Redirect("DoctorLogin.aspx");
        int empId = Convert.ToInt32(Session["doctorId"].ToString());
        Common_EmployeeNameBL objEmployeeNameBL = new Common_EmployeeNameBL();
        string empName = objEmployeeNameBL.Common_EmployeeName(empId);
        Label1.Text = "Welcome, " + empName;
        Label3.Text = "Last Login: " + Session["doctortLastLogin"].ToString();
    }
}
