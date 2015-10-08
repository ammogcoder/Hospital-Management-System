using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewOPDAppointmentHistory : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string appointmentToken = Request.QueryString["appointmenttoken"].ToString();
            Common_EncryptDecryptBL objCommon_EncryptDecryptBL = new Common_EncryptDecryptBL();
            appointmentToken = objCommon_EncryptDecryptBL.Decrypt(appointmentToken);
            Doctor_GetAppointmentDetailsByAppointmentTokenBL objDoctor_GetAppointmentDetailsByAppointmentTokenBL=new Doctor_GetAppointmentDetailsByAppointmentTokenBL();
            ds = objDoctor_GetAppointmentDetailsByAppointmentTokenBL.Doctor_GetAppointmentDetailsByAppointmentToken(appointmentToken);
            Label1.Text = appointmentToken;
            Label2.Text = ds.Tables[0].Rows[0]["APPOINTMENT_DATE"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["APPOINTMENT_TIME"].ToString();
            int patientId = Convert.ToInt32(ds.Tables[0].Rows[0]["PATIENT_ID_FK"].ToString());

            Doctor_GetOPDTreatmentMedicineBL objGetOPDTreatmentMedicineBL = new Doctor_GetOPDTreatmentMedicineBL();
            ds = objGetOPDTreatmentMedicineBL.Doctor_GetOPDTreatmentMedicine(appointmentToken);
            if(ds.Tables[0].Rows.Count == 0)
                Label4.Visible = true;
            else
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Label4.Visible = false;
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Label4.Visible = false;
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}