using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistSelectPatientForIPD : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if(!IsPostBack)
        {
            DropDownList2.Items.Add(new ListItem("--Select--", "0"));
            DropDownList3.Items.Add(new ListItem("--Select--", "0"));
            DropDownList5.Items.Add(new ListItem("--Select--", "0"));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        reset();
        Panel3.Visible = false;
        string patientName = TextBox1.Text;
        Common_SearchOPDPatientBL objSearchOPDPatientBL = new Common_SearchOPDPatientBL();
        ds = objSearchOPDPatientBL.Common_SearchOPDPatient(patientName);
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            Label1.Visible = true;
            Panel3.Visible = false;
        }
        else
        {
            Label1.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();
        Label4.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
        Panel3.Visible = true;
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Page.Validate();
        if(Page.IsValid)
        {
            int patientId = Convert.ToInt32(Label2.Text);
            int patientGeneralHealth = Convert.ToInt32(RadioButtonList2.SelectedValue);
            string patientRegularMedications = TextBox2.Text;
            int patientAllergyStatus = Convert.ToInt32(RadioButtonList1.SelectedValue);
            string patientAllergies = TextBox3.Text;
            int patientPastSurgeryStatus = Convert.ToInt32(RadioButtonList5.SelectedValue);
            string patientSurgery1 = TextBox4.Text;
            string patientSurgery1Date = "1900-01-01";
            if(TextBox4.Text != "")
                patientSurgery1Date = DateTime.ParseExact(TextBox5.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            string patientSurgery2 = TextBox6.Text;
            string patientSurgery2Date = "1900-01-01";
            if(TextBox6.Text != "")
                patientSurgery2Date = DateTime.ParseExact(TextBox7.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            string patientSurgery3 = TextBox8.Text;
            string patientSurgery3Date = "1900-01-01";
            if(TextBox8.Text != "")
                patientSurgery3Date = DateTime.ParseExact(TextBox9.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            int patientMedicalInsuranceStatus = Convert.ToInt32(RadioButtonList3.SelectedValue);
            string patientMedicalInsuranceProvider = "";
            string patientMedicalInsurancePolicyNumber = "";
            if(patientMedicalInsuranceStatus == 1)
            {
                patientMedicalInsuranceProvider = TextBox15.Text;
                patientMedicalInsurancePolicyNumber = TextBox16.Text;
            }
            string patientHeight = TextBox10.Text;
            string patientWeight = TextBox11.Text;
            string patientBloodGroup = DropDownList1.SelectedItem.Text;
            int patientAttendingDoctor = Convert.ToInt32(DropDownList2.SelectedValue);
            int patientAdmissionWard = Convert.ToInt32(DropDownList3.Text);
            int patientWardNumber = Convert.ToInt32(DropDownList5.Text);
            string patientDateOfAdmit = DateTime.ParseExact(TextBox18.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            string patientTimeOfAdmit = TextBox19.Text;
            string patientRemark = TextBox17.Text;

            RegisterIndoorPatientBL objRegisterIndoorPatientBL = new RegisterIndoorPatientBL();
            Session["ipdId"] = objRegisterIndoorPatientBL.RegisterIndoorPatient(patientId, patientGeneralHealth,
            patientRegularMedications, patientAllergyStatus, patientAllergies,
            patientPastSurgeryStatus, patientSurgery1, patientSurgery1Date, patientSurgery2,
            patientSurgery2Date, patientSurgery3, patientSurgery3Date,
            patientMedicalInsuranceStatus, patientMedicalInsuranceProvider,
            patientMedicalInsurancePolicyNumber, patientHeight, patientWeight, patientBloodGroup,
            patientAttendingDoctor, patientDateOfAdmit,
            patientTimeOfAdmit, patientRemark);

            AddCaseBL objAddCaseBL = new AddCaseBL();
            int caseId = objAddCaseBL.AddCase(patientAttendingDoctor, patientId, patientDateOfAdmit, DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString());

            AddWardEntryBL objAddWardEntryBL = new AddWardEntryBL();
            objAddWardEntryBL.AddWardEntry(patientAdmissionWard, patientWardNumber, patientId, caseId);

            UpdatePatientTypeBL objUpdatePatientTypeBL = new UpdatePatientTypeBL();
            objUpdatePatientTypeBL.UpdatePatientType(patientId, "IN");

            Panel2.Visible = true;
            Label3.Focus();
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox15.Enabled = false;
            TextBox16.Enabled = false;
            TextBox17.Enabled = false;
            TextBox18.Enabled = false;
            TextBox19.Enabled = false;
            RadioButtonList1.Enabled = false;
            RadioButtonList2.Enabled = false;
            RadioButtonList3.Enabled = false;
            RadioButtonList5.Enabled = false;
            DropDownList2.Enabled = false;
            DropDownList3.Enabled = false;
            DropDownList5.Enabled = false;
            Button2.Enabled = false;
            Button1.Enabled = false;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        reset();
    }
    private void reset()
    {
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
        TextBox15.Text = "";
        TextBox16.Text = "";
        TextBox17.Text = "";
        TextBox18.Text = "";
        TextBox19.Text = "";
        RadioButtonList1.ClearSelection();
        RadioButtonList2.ClearSelection();
        RadioButtonList3.ClearSelection();
        RadioButtonList5.ClearSelection();
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        DropDownList5.SelectedIndex = 0;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string patientName = Label4.Text;
        string patientId = Label2.Text;
        int empId = Convert.ToInt32(Session["receptionistId"].ToString());
        int ipdId = Convert.ToInt32(Session["ipdId"].ToString());
        AddIpdRegistrationReportBL objAddIpdRegistrationReportBL = new AddIpdRegistrationReportBL();
        string reportId = objAddIpdRegistrationReportBL.AddIpdRegistrationReport(empId, ipdId);

        string patientGeneralHealth = RadioButtonList2.SelectedItem.Text;
        string patientRegularMedications = TextBox1.Text;
        string patientAllergyStatus = RadioButtonList1.SelectedItem.Text;
        string patientAllergies = "NA";
        if(patientAllergyStatus == "Yes")
            patientAllergies = TextBox2.Text;
        string patientPastSurgeryStatus = RadioButtonList5.SelectedItem.Text;
        string patientSurgery1 = "NA";
        string patientSurgery1Date = "NA";
        string patientSurgery2 = "NA";
        string patientSurgery2Date = "NA";
        string patientSurgery3 = "NA";
        string patientSurgery3Date = "NA";
        if(patientPastSurgeryStatus == "Yes")
        {
            patientSurgery1 = TextBox3.Text;
            patientSurgery1Date = TextBox4.Text;
            patientSurgery2 = TextBox5.Text;
            patientSurgery2Date = TextBox6.Text;
            patientSurgery3 = TextBox7.Text;
            patientSurgery3Date = TextBox8.Text;
        }
        string patientMedicalInsuranceStatus = RadioButtonList3.SelectedItem.Text;
        string patientMedicalInsuranceProvider = "NA";
        string patientMedicalInsurancePolicyNumber = "NA";
        if(patientMedicalInsuranceStatus == "Yes")
        {
            patientMedicalInsuranceProvider = TextBox15.Text;
            patientMedicalInsurancePolicyNumber = TextBox16.Text;
        }
        string patientHeight = TextBox9.Text;
        string patientWeight = TextBox10.Text;
        string patientAttendingDoctor = DropDownList2.SelectedItem.Text;
        string patientAdmissionWard = DropDownList3.SelectedItem.Text;
        string patientWardNumber = DropDownList5.SelectedItem.Text;
        string patientDateOfAdmit = TextBox18.Text;
        string patientTimeOfAdmit = TextBox19.Text;
        string patientRemark = TextBox17.Text;

        PrintIPDRegistrationReportBL objPrintIPDRegistrationReportBL = new PrintIPDRegistrationReportBL();
        byte[] file = objPrintIPDRegistrationReportBL.PrintIPDRegistrationReport(reportId,
            patientName, patientId, patientGeneralHealth, patientRegularMedications,
            patientAllergyStatus, patientAllergies, patientPastSurgeryStatus, patientSurgery1,
            patientSurgery1Date, patientSurgery2, patientSurgery2Date, patientSurgery3,
            patientSurgery3Date, patientMedicalInsuranceStatus, patientMedicalInsuranceProvider,
            patientMedicalInsurancePolicyNumber, patientHeight, patientWeight,
            patientAttendingDoctor, patientAdmissionWard, patientWardNumber, patientDateOfAdmit,
            patientTimeOfAdmit, patientRemark);
        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.AddHeader("Content-Disposition", "attachment; filename=IPDRegistrationReport.pdf");
        Response.ContentType = "application/pdf";
        Response.Buffer = true;
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.BinaryWrite(file);
        Response.End();
        Response.Close();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        int wardId = Convert.ToInt32(DropDownList3.Text);
        GetWardNumberBL objGetWardNumberBL = new GetWardNumberBL();
        DropDownList5.Items.Clear();
        DropDownList5.Items.Add(new ListItem("--Select--", "0"));
        DropDownList5.DataSource = objGetWardNumberBL.GetWardNumber(wardId);
        DropDownList5.DataTextField = "WARD_NUMBER";
        DropDownList5.DataBind();
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(Convert.ToInt32(RadioButtonList1.SelectedValue) == 1)
        {
            TextBox3.Enabled = true;
            Label6.Visible = true;
        }
        else
        {
            TextBox3.Enabled = false;
            TextBox3.Text = "";
            Label6.Visible = false;
        }
    }
    protected void RadioButtonList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(Convert.ToInt32(RadioButtonList5.SelectedValue) == 1)
        {
            TextBox4.Enabled = TextBox5.Enabled = TextBox6.Enabled = TextBox7.Enabled = TextBox8.Enabled = TextBox9.Enabled = true;
            Label7.Visible = Label8.Visible = true;
        }
        else
        {
            TextBox4.Enabled = TextBox5.Enabled = TextBox6.Enabled = TextBox7.Enabled = TextBox8.Enabled = TextBox9.Enabled = false;
            Label7.Visible = Label8.Visible = false;
            TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox7.Text = TextBox8.Text = TextBox9.Text = "";
        }
    }
    protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(Convert.ToInt32(RadioButtonList3.SelectedValue) == 1)
        {
            TextBox15.Enabled = TextBox16.Enabled = true;
            Label9.Visible = Label10.Visible = true;
        }
        else
        {
            TextBox15.Enabled = TextBox16.Enabled = false;
            TextBox15.Text = TextBox16.Text = "";
            Label9.Visible = Label10.Visible = false;
        }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(Convert.ToInt32(RadioButtonList5.SelectedValue) == 1 && TextBox4.Text == "")
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(Convert.ToInt32(RadioButtonList5.SelectedValue) == 1 && TextBox5.Text == "")
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(Convert.ToInt32(RadioButtonList3.SelectedValue) == 1 && TextBox15.Text == "")
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    protected void CustomValidator4_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(Convert.ToInt32(RadioButtonList3.SelectedValue) == 1 && TextBox16.Text == "")
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    protected void CustomValidator5_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(Convert.ToInt32(RadioButtonList1.SelectedValue) == 1 && TextBox3.Text == "")
            args.IsValid = false;
        else
            args.IsValid = true;
    }
}