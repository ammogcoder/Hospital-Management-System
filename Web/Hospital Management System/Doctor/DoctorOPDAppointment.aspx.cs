using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorSelectOPDPatient : System.Web.UI.Page
{
    public static string appointmentToken;
    public static string appointmentTime;
    public static string appointmentDate;
    public static int patientId;
    public static DataSet ds = new DataSet();
    public static DataSet ds1 = new DataSet();
    public static DataSet ds2 = new DataSet();
    public static DataSet ds3 = new DataSet();
    public static List<Doctor_OPDTreatmentMedicineBO> objOPDTreatmentMedicineBOList = new List<Doctor_OPDTreatmentMedicineBO>();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds1;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string token = ds1.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();
        Common_EncryptDecryptBL objCommon_EncryptDecryptBL = new Common_EncryptDecryptBL();
        token = objCommon_EncryptDecryptBL.Common_Encrypt(token);
        string url = "DoctorViewOPDAppointmentHistory.aspx?appointmenttoken=" + token;
        string script = "window.open('" + url + "', '_blank', 'width=1000, height=650');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", script, true);   
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        int medicineType = Convert.ToInt32(DropDownList1.SelectedValue);
        Doctor_GetMedicineNameByTypeBL objGetMedicineNameByTypeBL = new Doctor_GetMedicineNameByTypeBL();
        DropDownList2.DataSource = objGetMedicineNameByTypeBL.Doctor_GetMedicineNameByType(medicineType);
        DropDownList2.DataTextField = "MEDICINE_NAME";
        DropDownList2.DataValueField = "ID";
        DropDownList2.DataBind();
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        appointmentToken = TextBox7.Text;
        reset();
        GetPatientInfoByAppointmentTokenBL objGetPatientInfoByAppointmentTokenBL = new GetPatientInfoByAppointmentTokenBL();
        ds = objGetPatientInfoByAppointmentTokenBL.GetPatientInfoByAppointmentToken(appointmentToken);
        if(ds.Tables[0].Rows.Count != 0)
        {
            Panel1.Visible = true;
            patientId = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
            Label2.Text = ds.Tables[0].Rows[0]["PATIENT_NAME"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["PATIENT_DOB"].ToString();
            Label4.Text = ds.Tables[0].Rows[0]["PATIENT_PRIMARY_PHONE"].ToString();
            appointmentDate = ds.Tables[0].Rows[0]["APPOINTMENT_DATE"].ToString();
            appointmentTime = ds.Tables[0].Rows[0]["APPOINTMENT_TIME"].ToString();
            DateTime dt = Convert.ToDateTime(appointmentDate);
            if(dt == DateTime.Now.Date)
            {              
                Label5.Text = "";
                Panel2.Visible = true;
                Panel3.Visible = true;
                Panel4.Visible = false;
                LinkButton2.Visible = false;
                GetPatientAppointmentHistoryBL objGetPatientAppointmentHistoryBL = new GetPatientAppointmentHistoryBL();
                ds1 = objGetPatientAppointmentHistoryBL.GetPatientAppointmentHistory(patientId);
                GridView1.DataSource = ds1;
                GridView1.DataBind();
                Doctor_GetOPDTreatmentAllMedicinesBL objGetOPDTreatmentAllMedicinesBL = new Doctor_GetOPDTreatmentAllMedicinesBL();
                ds2 = objGetOPDTreatmentAllMedicinesBL.Doctor_GetOPDTreatmentAllMedicines(patientId);
                GridView2.DataSource = ds2;
                GridView2.DataBind();
                GridView3.DataSource = null;
                GridView3.DataBind();
            }
            else
            {
                Panel2.Visible = false;
                Panel3.Visible = true;
                Panel4.Visible = false;
                LinkButton2.Visible = false;
                Label5.Text = "Patient Does Not Have Appointment Today";
                Label5.ForeColor = System.Drawing.Color.Red;
                Label5.BackColor = System.Drawing.Color.Yellow;
                GetPatientAppointmentHistoryBL objGetPatientAppointmentHistoryBL = new GetPatientAppointmentHistoryBL();
                ds1 = objGetPatientAppointmentHistoryBL.GetPatientAppointmentHistory(patientId);
                GridView1.DataSource = ds1;
                GridView1.DataBind();
                Doctor_GetOPDTreatmentAllMedicinesBL objGetOPDTreatmentAllMedicinesBL = new Doctor_GetOPDTreatmentAllMedicinesBL();
                ds2 = objGetOPDTreatmentAllMedicinesBL.Doctor_GetOPDTreatmentAllMedicines(patientId);
                GridView2.DataSource = ds2;
                GridView2.DataBind();
                GridView3.DataSource = null;
                GridView3.DataBind();
            }
        }
        else
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            LinkButton2.Visible = false;
            Label5.Text = "No Patient Found";
            Label5.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int medicineTypeId = Convert.ToInt32(DropDownList1.SelectedValue);
        int medicineNameId = Convert.ToInt32(DropDownList2.SelectedValue);
        string medicineStrength = TextBox1.Text;
        string medicineQuantity = TextBox4.Text;
        string medicineStartDate = DateTime.ParseExact(TextBox5.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        int numberOfRefills = Convert.ToInt32(TextBox2.Text);
        string quantityOnRefills = TextBox6.Text;
        string medicineInstructions = TextBox3.Text;

        Doctor_OPDTreatmentMedicineBO objOPDTreatmentMedicineBO = new Doctor_OPDTreatmentMedicineBO();
        objOPDTreatmentMedicineBO.medicineInstructions = medicineInstructions;
        objOPDTreatmentMedicineBO.medicineType = DropDownList1.SelectedItem.Text;
        objOPDTreatmentMedicineBO.medicineName = DropDownList2.SelectedItem.Text;
        objOPDTreatmentMedicineBO.medicineStrength = TextBox1.Text;
        objOPDTreatmentMedicineBO.medicineQuantity = TextBox4.Text;
        objOPDTreatmentMedicineBO.medicineStartDate = TextBox5.Text;
        objOPDTreatmentMedicineBO.numberOfRefills = Convert.ToInt32(TextBox2.Text);
        objOPDTreatmentMedicineBO.quantityOnRefills = TextBox6.Text;
        objOPDTreatmentMedicineBO.medicineInstructions = TextBox3.Text;

        objOPDTreatmentMedicineBOList.Add(objOPDTreatmentMedicineBO);

        Doctor_AddOPDTreatmentMedicineBL objAddOPDTreatmentMedicineBL = new Doctor_AddOPDTreatmentMedicineBL();
        objAddOPDTreatmentMedicineBL.Doctor_AddOPDTreatmentMedicine(appointmentToken, medicineTypeId,
            medicineNameId, medicineStrength, medicineQuantity, medicineStartDate, numberOfRefills,
            quantityOnRefills, medicineInstructions);

        Doctor_GetOPDTreatmentMedicineBL objGetOPDTreatmentMedicineBL = new Doctor_GetOPDTreatmentMedicineBL();
        GridView3.DataSource = objGetOPDTreatmentMedicineBL.Doctor_GetOPDTreatmentMedicine(appointmentToken);
        GridView3.DataBind();
        Panel4.Visible = true;
        LinkButton2.Visible = false;
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void reset()
    {
        TextBox1.Text = TextBox2.Text = TextBox3.Text = TextBox4.Text = TextBox5.Text = TextBox6.Text = TextBox8.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton linkbutton = sender as LinkButton;
        GridViewRow row = linkbutton.NamingContainer as GridViewRow;
        int treatmentMedicineId = Convert.ToInt32(GridView3.DataKeys[row.RowIndex].Value.ToString());
        
        Doctor_DeleteOPDTreatmentMedicineDL objDeleteTreatmentMedicineBL = new Doctor_DeleteOPDTreatmentMedicineDL();
        objDeleteTreatmentMedicineBL.Doctor_DeleteOPDTreatmentMedicine(treatmentMedicineId);
        
        Doctor_GetOPDTreatmentMedicineBL objGetOPDTreatmentMedicineBL = new Doctor_GetOPDTreatmentMedicineBL();
        GridView3.DataSource = objGetOPDTreatmentMedicineBL.Doctor_GetOPDTreatmentMedicine(appointmentToken);
        GridView3.DataBind();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        reset();
        string treatmentDiagnosis = TextBox8.Text;
        Doctor_AddOPDTreatmentBL objAddOPDTreatmentBL = new Doctor_AddOPDTreatmentBL();
        objAddOPDTreatmentBL.Doctor_AddOPDTreatment(appointmentToken, treatmentDiagnosis);
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = false;
        Label5.Text = "OPD Prescription Saved";
        Label5.ForeColor = System.Drawing.Color.Black;
        Label5.BackColor = System.Drawing.Color.Yellow;
        LinkButton2.Visible = true;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        reset();
        int empId = Convert.ToInt32(Session["doctorId"].ToString());

        Doctor_AddOPDPrescriptionReportBL objAddOPDPrescriptionReportBL=new Doctor_AddOPDPrescriptionReportBL();
        string reportId = objAddOPDPrescriptionReportBL.Doctor_AddOPDPrescriptionReport(empId, appointmentToken);

        Common_GetEmployeeNameByIdBL objGetEmployeeNameByIdBL = new Common_GetEmployeeNameByIdBL();
        string empName=objGetEmployeeNameByIdBL.Common_GetEmployeeNameById(empId);

        Doctor_PrintOPDPrescriptionReportBL objPrintOPDPrescriptionReportBL = new Doctor_PrintOPDPrescriptionReportBL();
        byte[] file = objPrintOPDPrescriptionReportBL.Doctor_PrintOPDPrescriptionReport(reportId, appointmentToken,
            empName, appointmentDate, appointmentTime, patientId.ToString(), 
            Label2.Text, objOPDTreatmentMedicineBOList, TextBox8.Text);

        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.AddHeader("Content-Disposition", "attachment; filename=OPDPrescriptionReport.pdf");
        Response.ContentType = "application/pdf";
        Response.Buffer = true;
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.BinaryWrite(file);
        Response.End();
        Response.Close();
    }
}