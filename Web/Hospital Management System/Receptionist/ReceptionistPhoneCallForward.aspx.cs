using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Receptionist_ReceptionistPhoneCallForward : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            Common_GetAllEmployeesBL objGetAllEmployeesBL = new Common_GetAllEmployeesBL();
            DropDownList1.DataSource = objGetAllEmployeesBL.Common_GetAllEmployees(Convert.ToInt32(Session["receptionistId"].ToString()));
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataTextField = "EMPLOYEE_NAME";
            DropDownList1.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int receptionistId = Convert.ToInt32(Session["receptionistId"].ToString());
        string phoneNo = TextBox4.Text;
        string callDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string callTime = TextBox2.Text;
        string callerName = TextBox3.Text;
        int callForwardedTo = Convert.ToInt32(DropDownList1.SelectedValue);

        AddPhoneCallForwardBL objAddPhoneCallForwardBL = new AddPhoneCallForwardBL();
        objAddPhoneCallForwardBL.AddPhoneCallForward(receptionistId, phoneNo, callDate, callTime, callerName, callForwardedTo);

        Label6.Text = "Phone Record Saved";

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        DropDownList1.SelectedIndex = 0;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        DropDownList1.SelectedIndex = 0;
        Label6.Text = "";
    }
}