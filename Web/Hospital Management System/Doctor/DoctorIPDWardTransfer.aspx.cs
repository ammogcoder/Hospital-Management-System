using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Doctor_DoctorIPDWardTransfer : System.Web.UI.Page
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
        DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        int wardId = Convert.ToInt32(DropDownList1.SelectedValue);
        GetWardNumberBL objGetWardNumberBL = new GetWardNumberBL();
        DropDownList2.DataSource = objGetWardNumberBL.GetWardNumber(wardId);
        DropDownList2.DataTextField = "WARD_NUMBER";
        DropDownList2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int patientId = Convert.ToInt32(Session["patientId"].ToString());
        int previousWardId = Convert.ToInt32(Session["previousWardId"].ToString());
        int previousardNumber = Convert.ToInt32(Session["previousardNumber"].ToString());
        string transferDate = DateTime.ParseExact(TextBox3.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string transferTime = TextBox4.Text;
        string reasonForTransfer = TextBox2.Text;
        int newWardId = Convert.ToInt32(DropDownList1.SelectedValue);
        int newWardNumber = Convert.ToInt32(DropDownList2.Text);

        Common_PatientWardTransferBL objCommon_PatientWardTransferBL = new Common_PatientWardTransferBL();
        Session["wardTransferId"] = objCommon_PatientWardTransferBL.Common_PatientWardTransfer(patientId, previousWardId, previousardNumber, transferDate, transferTime, reasonForTransfer, newWardId, newWardNumber, Convert.ToInt32(Session["doctorId"].ToString()));
        Label1.Visible = true;
        reset();
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