using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistPatientDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int patientId = Convert.ToInt32(Request.QueryString["patientId"].ToString());
            Common_GetPatientDetailsBL objGetPatientDetailsBL = new Common_GetPatientDetailsBL();
            DataSet ds = new DataSet();
            ds = objGetPatientDetailsBL.Common_GetPatientDetails(patientId);
            Label1.Text = patientId.ToString();
            Label2.Text = ds.Tables[0].Rows[0]["PREFIX"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["PATIENT_FIRST_NAME"].ToString();
            Label4.Text = ds.Tables[0].Rows[0]["PATIENT_LAST_NAME"].ToString();
            Label5.Text = ds.Tables[0].Rows[0]["PATIENT_DOB"].ToString();
            Label6.Text = ds.Tables[0].Rows[0]["MARITAL_STATUS"].ToString();
            Label8.Text = ds.Tables[0].Rows[0]["GENDER"].ToString();
            Label9.Text = ds.Tables[0].Rows[0]["PATIENT_STREET_ADDRESS"].ToString();
            Label10.Text = ds.Tables[0].Rows[0]["PATIENT_CITY"].ToString();
            Label11.Text = ds.Tables[0].Rows[0]["PATIENT_ZIP_CODE"].ToString();
            Label12.Text = ds.Tables[0].Rows[0]["PATIENT_STATE"].ToString();
            Label13.Text = ds.Tables[0].Rows[0]["PATIENT_COUNTRY"].ToString();
            Label14.Text = ds.Tables[0].Rows[0]["PATIENT_PRIMARY_PHONE"].ToString();
            Label15.Text = ds.Tables[0].Rows[0]["PATIENT_SECONDARY_PHONE"].ToString();
            Label16.Text = ds.Tables[0].Rows[0]["PATIENT_EMERGENCY_CONTACT"].ToString();
            Label17.Text = ds.Tables[0].Rows[0]["PATIENT_EMERGENCY_PHONE"].ToString();
            Label18.Text = ds.Tables[0].Rows[0]["PATIENT_EMAIL"].ToString();
            Label19.Text = ds.Tables[0].Rows[0]["OCCUPATION"].ToString();
            Label20.Text = ds.Tables[0].Rows[0]["PATIENT_EMPLOYER_NAME"].ToString();
            Label21.Text = ds.Tables[0].Rows[0]["PATIENT_EMPLOYER_STREET_ADDRESS"].ToString();
            Label22.Text = ds.Tables[0].Rows[0]["PATIENT_EMPLOYER_CITY"].ToString();
            Label23.Text = ds.Tables[0].Rows[0]["PATIENT_EMPLOYER_STATE"].ToString();
            Label24.Text = ds.Tables[0].Rows[0]["PATIENT_EMPLOYER_COUNTRY"].ToString();
            if (Label19.Text == "Unemployed")
                Label20.Text = Label21.Text = Label22.Text = Label23.Text = Label24.Text = "NA";
            Label25.Text = ds.Tables[0].Rows[0]["PATIENT_LANGUAGE"].ToString();
            Label26.Text = ds.Tables[0].Rows[0]["PATIENT_REFERENCE"].ToString();
            Label28.Text = ds.Tables[0].Rows[0]["PATIENT_FAMILY_SIZE"].ToString();
            Label29.Text = ds.Tables[0].Rows[0]["PATIENT_MONTHLY_INCOME"].ToString();
            if (Label19.Text == "Unemployed")
                Label29.Text = "NA";
            Label27.Text = ds.Tables[0].Rows[0]["REFERENCE_SOURCE"].ToString();
            if (Label27.Text != "Patient" || Label27.Text != "Employee")
                Label26.Text = "NA";
            Label30.Text = ds.Tables[0].Rows[0]["PATIENT_REGISTRATION_DATE_TIME"].ToString();
        }
    }
}