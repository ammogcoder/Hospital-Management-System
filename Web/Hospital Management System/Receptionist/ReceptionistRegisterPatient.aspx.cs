using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Receptionist_ReceptionistRegisterPatient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
            DropDownList3.Items.Add(new ListItem("--Select--", "0"));
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string patientFirstName = TextBox1.Text;
        string patientMiddleName = TextBox2.Text;
        string patientLastName = TextBox3.Text;
        string patientDOB = DateTime.ParseExact(TextBox4.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string patientGender = RadioButtonList1.SelectedValue;
        string patientMaritalStatus = DropDownList1.SelectedValue;
        string patientFatherName = TextBox5.Text;
        string patientPrimaryAddress = TextBox6.Text;
        string patientSecondaryAddress = TextBox7.Text;
        string patientPrimaryPhone = TextBox8.Text;
        string patientSecondaryPhone = TextBox9.Text;
        string patientEmail = TextBox10.Text;
        string patientEmergencyContactName = TextBox11.Text;
        string patientEmergencyContactNumber = TextBox12.Text;
        int patientOccupationType = Convert.ToInt32(DropDownList2.SelectedValue);
        string patientOccupationName = TextBox18.Text;
        string occupationAddress = TextBox13.Text;
        string patientMonthlyIncome = TextBox14.Text;
        int patientReference = Convert.ToInt32(DropDownList3.SelectedValue);
        int patientReferenceSourceId = Convert.ToInt32(Session["patientId"]);
        string patientPrimaryLanguage = TextBox15.Text;
        string patientFamilySize = TextBox16.Text;

        RegisterPatientBL objRegisterPatientBL = new RegisterPatientBL();
        int patientId = objRegisterPatientBL.RegisterPatient(patientFirstName, patientMiddleName,
            patientLastName, patientDOB, patientGender, patientMaritalStatus, patientFatherName, 
            patientPrimaryAddress, patientSecondaryAddress, patientPrimaryPhone, patientSecondaryPhone,
            patientEmail, patientEmergencyContactName, patientEmergencyContactNumber, 
            patientOccupationType, patientOccupationName, occupationAddress, patientMonthlyIncome,
            patientReference, patientReferenceSourceId, patientPrimaryLanguage, patientFamilySize, Convert.ToInt32(Session["empId"].ToString()));

        AddPatientTypeBL objAddPatientTypeBL = new AddPatientTypeBL();
        objAddPatientTypeBL.AddPatientType(patientId);
        reset();
        Label3.Visible = true;
        Label3.Text = "Patient Registered";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        reset();
    }
    protected void reset()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        TextBox14.Text = "";
        TextBox15.Text = "";
        TextBox16.Text = "";
        TextBox17.Text = "";
        TextBox18.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ModalPopupExtender1.Show();
        string patientName = TextBox17.Text;
        Receptionist_SearchIPDPatientBL objSearchPatientBL = new Receptionist_SearchIPDPatientBL();
        GridView1.DataSource = objSearchPatientBL.Receptionist_SearchIPDPatient(patientName);
        GridView1.DataBind();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        int refSource = Convert.ToInt32(DropDownList3.SelectedValue);
        if (refSource == 1)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            TextBox17.Text = "";
            ModalPopupExtender1.Show();
        }
        else
        {
            Label2.Text = "";
            Session["patientId"] = null;
            Session["patientName"] = null;
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["patientId"] = GridView1.SelectedRow.Cells[0].Text.ToString();
        Session["patientName"] = GridView1.SelectedRow.Cells[1].Text.ToString();
        Panel2.Visible = true;
        Panel3.Visible = false;
        Label2.Text = Session["patientName"].ToString();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Visible = false;
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["patientId"] = null;
        Session["patientName"] = null;
        Label2.Text = "";
        DropDownList3.SelectedIndex = 0;
        Panel2.Visible = false;
        Panel3.Visible = true;
    }
}