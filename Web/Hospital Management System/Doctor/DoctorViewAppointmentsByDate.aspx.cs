using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using ASPSnippets.SmsAPI;

public partial class Doctor_DoctorViewCalendarAppointments : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if(!IsPostBack)
        {
            GetAppointmentData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string appointmentToken = Label3.Text;
        string oldAppointmentDate = Request.QueryString["date"].ToString();
        string newAppointmentDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string newAppointmentTime = TextBox2.Text;

        EditAppointmentBL objEditAppointmentBL = new EditAppointmentBL();
        objEditAppointmentBL.EditAppointment(appointmentToken, oldAppointmentDate, newAppointmentDate, newAppointmentTime);
        Panel1.Visible = true;
        TextBox1.Enabled = false;
        TextBox1.Text = "";
        TextBox2.Enabled = false;
        TextBox2.Text = "";
        Button1.Enabled = false;
        GetAppointmentData();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int empId = Convert.ToInt32(Session["receptionistId"].ToString());
        string appointmentToken = Label3.Text;
        string appointmentDate = TextBox1.Text;
        string appointmentTime = TextBox2.Text;

        GetDoctorNameByAppointmentTokenBL objGetDoctorNameByAppointmentTokenBL = new GetDoctorNameByAppointmentTokenBL();
        string doctorName = objGetDoctorNameByAppointmentTokenBL.GetDoctorNameByAppointmentToken(Label3.Text);

        AddAppointmentInvoiceBL objAddAppointmentInvoiceBL = new AddAppointmentInvoiceBL();
        string invoiceId = objAddAppointmentInvoiceBL.AddAppointmentInvoice(empId, appointmentToken);

        PrintAppointmentInvoiceBL objPrintAppointmentInvoiceBL = new PrintAppointmentInvoiceBL();
        byte[] file = objPrintAppointmentInvoiceBL.PrintAppointmentInvoice(invoiceId, appointmentToken, doctorName, appointmentDate, appointmentTime);
        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.AddHeader("Content-Disposition", "attachment; filename=AppointmentInvoice.pdf");
        Response.ContentType = "application/pdf";
        Response.Buffer = true;
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.BinaryWrite(file);
        Response.End();
        Response.Close();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        string oldAppointmentDate = Request.QueryString["date"].ToString();
        string newAppointmentDate = TextBox1.Text;
        string newAppointmentTime = TextBox2.Text;

        SMS.APIType = SMSGateway.Site2SMS;
        SMS.MashapeKey = "qsdptI9i8PmshCC3BzZtyTTZVMtqp1CKzOYjsnHn0tfnCt11sT";
        SMS.Username = "919067661606";
        SMS.Password = "273053";
        string appointmentToken = Session["appointmentToken"].ToString();

        GetDoctorNameByAppointmentTokenBL objGetDoctorNameByAppointmentTokenBL = new GetDoctorNameByAppointmentTokenBL();
        string doctorName = objGetDoctorNameByAppointmentTokenBL.GetDoctorNameByAppointmentToken(appointmentToken);

        DataSet ds = new DataSet();
        GetPatientInfoByAppointmentTokenBL objGetPatientInfoByAppointmentTokenBL = new GetPatientInfoByAppointmentTokenBL();
        ds = objGetPatientInfoByAppointmentTokenBL.GetPatientInfoByAppointmentToken(appointmentToken);
        string patientPrimaryPhone = ds.Tables[0].Rows[0]["PATIENT_PRIMARY_PHONE"].ToString();

        Common_GetSMSTemplateBL objGetSMSTemplateBL = new Common_GetSMSTemplateBL();
        string SMStemplate = objGetSMSTemplateBL.Common_GetSMSTemplate(1);
        var regex = new Regex(Regex.Escape("#"));
        string SMSMessage = regex.Replace(SMStemplate, doctorName, 1);
        SMSMessage = regex.Replace(SMSMessage, oldAppointmentDate, 2);
        SMSMessage = regex.Replace(SMSMessage, newAppointmentDate, 3);
        SMSMessage = regex.Replace(SMSMessage, newAppointmentTime, 4);
        SMS.SendSms(patientPrimaryPhone, SMSMessage);
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        string appointmentDate = Request.QueryString["date"].ToString();
        string appointmentToken = Request.QueryString["Cancel"].ToString();

        SMS.APIType = SMSGateway.Site2SMS;
        SMS.MashapeKey = "qsdptI9i8PmshCC3BzZtyTTZVMtqp1CKzOYjsnHn0tfnCt11sT";
        SMS.Username = "919067661606";
        SMS.Password = "273053";

        GetDoctorNameByAppointmentTokenBL objGetDoctorNameByAppointmentTokenBL = new GetDoctorNameByAppointmentTokenBL();
        string doctorName = objGetDoctorNameByAppointmentTokenBL.GetDoctorNameByAppointmentToken(appointmentToken);

        DataSet ds1 = new DataSet();
        GetPatientInfoByAppointmentTokenBL objGetPatientInfoByAppointmentTokenBL = new GetPatientInfoByAppointmentTokenBL();
        ds1 = objGetPatientInfoByAppointmentTokenBL.GetPatientInfoByAppointmentToken(appointmentToken);
        string patientPrimaryPhone = ds1.Tables[0].Rows[0]["PATIENT_PRIMARY_PHONE"].ToString();

        Common_GetSMSTemplateBL objGetSMSTemplateBL = new Common_GetSMSTemplateBL();
        string SMStemplate = objGetSMSTemplateBL.Common_GetSMSTemplate(1);
        var regex = new Regex(Regex.Escape("#"));
        string SMSMessage = regex.Replace(SMStemplate, doctorName, 1);
        SMSMessage = regex.Replace(SMSMessage, appointmentDate, 2);
        SMS.SendSms(patientPrimaryPhone, SMSMessage);
        //Label1.Text = SMSMessage;
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
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
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        foreach(GridViewRow row in GridView1.Rows)
        {
            if(row.RowType == DataControlRowType.DataRow)
            {
                CheckBox cb = (row.Cells[0].FindControl("CheckBox1") as CheckBox);
                if(cb.Checked)
                {
                    string appointmentToken = row.Cells[3].Text;
                    CancelAppointmentBL objCancelAppointmentBL = new CancelAppointmentBL();
                    objCancelAppointmentBL.CancelAppointment(appointmentToken);
                }
            }
            Label2.Visible = true;
            Response.Redirect("DoctortViewCalendarAppointments.aspx?date=" + Request.QueryString["date"].ToString());
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string appointmentToken = ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString();
        MultiView1.ActiveViewIndex = 0;
        Label3.Text = appointmentToken;
        Button1.Enabled = true;
        TextBox1.Enabled = true;
        TextBox2.Enabled = true;
        Panel1.Visible = false;
        GetAppointmentData();
    }
    private void GetAppointmentData()
    {
        Doctor_GetAppointmentsByDateBL objDoctor_GetAppointmentsByDateBL = new Doctor_GetAppointmentsByDateBL();
        ds = objDoctor_GetAppointmentsByDateBL.Doctor_GetAppointmentsByDate(Convert.ToInt32(Session["doctorId"].ToString()), Request.QueryString["date"].ToString());
        if(ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
            Panel2.Visible = false;
            GridView1.DataSource = null;
            GridView1.DataBind();
        }
        else
        {
            Label1.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}