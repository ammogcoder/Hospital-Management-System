using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doctor_DoctorTransferIPD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        Doctor_GetDoctorByDepartmentBL objDoctor_GetDoctorByDepartmentBL = new Doctor_GetDoctorByDepartmentBL();
        DropDownList2.DataSource = objDoctor_GetDoctorByDepartmentBL.Doctor_GetDoctorByDepartment(Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToInt32(Session["doctorId"].ToString()));
        DropDownList2.DataValueField = "ID";
        DropDownList2.DataTextField = "DOCTOR_NAME";
        DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        DropDownList2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string transferDate = DateTime.ParseExact(TextBox3.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string transferTime = TextBox4.Text;
        string reasonForTransfer = TextBox2.Text;
        int transferToDoctorId = Convert.ToInt32(DropDownList2.SelectedValue);
        int transferByDoctorId = Convert.ToInt32(Session["doctorId"].ToString());
        int patientId = Convert.ToInt32(Session["patientId"].ToString());

        Doctor_IPDDoctorTransferBL objDoctor_IPDDoctorTransferBL = new Doctor_IPDDoctorTransferBL();
        Session["transferToDoctorId"] = objDoctor_IPDDoctorTransferBL.Doctor_IPDDoctorTransfer(transferDate, transferTime, reasonForTransfer, transferToDoctorId,
            transferByDoctorId, patientId);
        Label1.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        reset();
    }
    private void reset()
    {
        TextBox2.Text = TextBox3.Text = TextBox4.Text = "";
        DropDownList1.SelectedIndex = DropDownList2.SelectedIndex = 0;
    }
}