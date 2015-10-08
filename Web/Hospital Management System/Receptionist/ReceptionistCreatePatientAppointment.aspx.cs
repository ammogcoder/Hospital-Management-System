using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistSelectPatient : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            DropDownList2.Items.Add(new ListItem("--Select--", "0"));
            DropDownList3.Items.Add(new ListItem("--Select--", "0"));
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Label2.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();
        Label4.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString();
        string url = "ReceptionistViewPatientAppointmentHistory.aspx?patientid=" + Label2.Text;
        HyperLink2.Target = "_blank";
        HyperLink2.NavigateUrl = "javascript:void(0)";
        HyperLink2.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=700,scrollbars');");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string patientName = TextBox1.Text;
        Common_SearchOPDPatientBL objSearchOPDPatientBL = new Common_SearchOPDPatientBL();
        ds = objSearchOPDPatientBL.Common_SearchOPDPatient(patientName);
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            Label1.Visible = true;
        }
        else
        {
            Label1.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        int departmentId = Convert.ToInt32(DropDownList1.SelectedValue);
        Common_DoctorByDepartmentBL objDoctorByDepartmentBL = new Common_DoctorByDepartmentBL();
        DropDownList2.DataSource = objDoctorByDepartmentBL.Common_DoctorByDepartment(departmentId);
        DropDownList2.DataValueField = "ID";
        DropDownList2.DataTextField = "DOCTOR_NAME";
        DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        DropDownList2.DataBind();
        Panel2.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        GetEmployeeLeaveBL objGetEmployeeLeaveBL = new GetEmployeeLeaveBL();
        DataSet ds1 = objGetEmployeeLeaveBL.GetEmployeeLeave(Convert.ToInt32(DropDownList2.SelectedValue));
        string leaveFromDate = null;
        string leaveToDate = null;
        string leaveFromTime = null;
        string leaveToTime = null;
        if (ds1.Tables[0].Rows.Count != 0)
        {
            leaveFromDate = ds1.Tables[0].Rows[0]["FROM_DATE"].ToString();
            leaveToDate = ds1.Tables[0].Rows[0]["TO_DATE"].ToString();
            leaveFromTime = ds1.Tables[0].Rows[0]["FROM_TIME"].ToString();
            leaveToTime = ds1.Tables[0].Rows[0]["TO_TIME"].ToString();
        }
        string appointmentDate = DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string appointmentTime = TextBox3.Text;

        DateTime appointmentDateDateTime = Convert.ToDateTime(appointmentDate);
        DateTime appointmentTimeDateTime = Convert.ToDateTime(appointmentTime);
        if (ds1.Tables[0].Rows.Count != 0)
        {
            DateTime leaveFromDateDateTime = Convert.ToDateTime(leaveFromDate);
            DateTime leaveFromTimeDateTime = DateTime.ParseExact(leaveFromTime, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime leaveToDateDateTime = Convert.ToDateTime(leaveToDate);
            DateTime leaveToTimeDateTime = DateTime.ParseExact(leaveToTime, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);

            if((DateTime.Compare(appointmentDateDateTime, leaveToDateDateTime) < 0) && (DateTime.Compare(leaveFromDateDateTime, appointmentDateDateTime) < 0))
            {
                Label3.Text = "Doctor Unavailable From " + leaveFromTime + " " + leaveFromDate + " To " + leaveToTime + " " + leaveToDate;
                MultiView1.ActiveViewIndex = 0;
            }
            else if ((DateTime.Compare(leaveToDateDateTime, appointmentDateDateTime) == 0) && DateTime.Compare(leaveToTimeDateTime, appointmentTimeDateTime) > 0)
            {
                Label3.Text = "Doctor Unavailable From " + leaveFromTime + " " + leaveFromDate + " To " + leaveToTime + " " + leaveToDate;
                MultiView1.ActiveViewIndex = 0;
            }
            else
            {
                int doctorId = Convert.ToInt32(DropDownList2.SelectedValue);
                Common_GetDoctorAppointmentByDateTimeBL objGetDoctorAppointmentDateTimeBL = new Common_GetDoctorAppointmentByDateTimeBL();
                ds = objGetDoctorAppointmentDateTimeBL.Common_GetDoctorAppointmentByDateTime(doctorId, appointmentDate, appointmentTime);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    Label3.Text = "Doctor Already Has An Appointment On " + appointmentDateDateTime.Date.ToShortDateString() + " " + appointmentTime;
                    MultiView1.ActiveViewIndex = 0;
                }
                else
                {
                    AddPatientAppointmentBL objAddPatientAppointmentBL = new AddPatientAppointmentBL();
                    doctorId = Convert.ToInt32(DropDownList2.SelectedValue);
                    appointmentDate = DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
                    appointmentTime = TextBox3.Text;
                    int bodyPartId = Convert.ToInt32(DropDownList3.SelectedValue);
                    string problemDesciption = TextBox4.Text;
                    string appointmentToken = objAddPatientAppointmentBL.AddPatientAppointment(Convert.ToInt32(Label2.Text), doctorId, appointmentDate, appointmentTime, bodyPartId, problemDesciption);
                    Session["appointmentToken"] = appointmentToken;
                    Label5.Text = "Appointment Created. Appointment token is <b>" + appointmentToken + "</b>";
                    MultiView1.ActiveViewIndex = 1;

                    TextBox2.Enabled = false;
                    TextBox3.Enabled = false;
                    TextBox4.Enabled = false;
                    DropDownList1.Enabled = false;
                    DropDownList2.Enabled = false;
                    DropDownList3.Enabled = false;
                }
            }
        }
        else
        {
            AddPatientAppointmentBL objAddPatientAppointmentBL = new AddPatientAppointmentBL();
            int doctorId = Convert.ToInt32(DropDownList2.SelectedValue);
            appointmentDate = DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
            appointmentTime = TextBox3.Text;
            int bodyPartId = Convert.ToInt32(DropDownList3.SelectedValue);
            string problemDesciption = TextBox4.Text;
            string appointmentToken = objAddPatientAppointmentBL.AddPatientAppointment(Convert.ToInt32(Label2.Text), doctorId, appointmentDate, appointmentTime, bodyPartId, problemDesciption);
            Session["appointmentToken"] = appointmentToken;
            Label5.Text = "Appointment Created. Appointment token is <b>" + appointmentToken + "</b>";
            MultiView1.ActiveViewIndex = 1;

            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            DropDownList1.Enabled = false;
            DropDownList2.Enabled = false;
            DropDownList3.Enabled = false;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.Text != "--Select--")
        {
            Panel2.Visible = true;
            string url = "ReceptionistViewDoctorSchedule.aspx?doctorId=" + DropDownList2.SelectedValue;
            HyperLink1.Target = "_blank";
            HyperLink1.NavigateUrl = "javascript:void(0)";
            HyperLink1.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=700,scrollbars');");
        }
        else
            Panel2.Visible = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string appointmentToken = Session["appointmentToken"].ToString();
        AddAppointmentInvoiceBL objAddAppointmentInvoiceBL = new AddAppointmentInvoiceBL();
        string invoiceId = objAddAppointmentInvoiceBL.AddAppointmentInvoice(Convert.ToInt32(Session["receptionistId"].ToString()), appointmentToken);
        string appointmentDate = DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string appointmentTime = TextBox3.Text;
        string doctorName = DropDownList2.SelectedItem.Text;
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
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
}