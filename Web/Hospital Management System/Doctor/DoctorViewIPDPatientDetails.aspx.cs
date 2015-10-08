using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewIPDPatientDetails : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    public static int doctorId;
    public static int patientId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            doctorId = Convert.ToInt32(Session["doctorId"].ToString());
            patientId = Convert.ToInt32(Session["patientId"].ToString());
            GetMedicalDetailsData();
            GetPersonalDetailsData();
        }
    }
    private void GetMedicalDetailsData()
    {
        Doctor_GetIPDPatientDetailsBL objDoctor_GetIPDPatientDetailsBL = new Doctor_GetIPDPatientDetailsBL();
        ds = objDoctor_GetIPDPatientDetailsBL.Doctor_GetIPDPatientDetails(patientId, doctorId);
        Label3.Text = ds.Tables[0].Rows[0]["PATIENT_GENERAL_HEALTH"].ToString();
        Label4.Text = ds.Tables[0].Rows[0]["PATIENT_REGULAR_MEDICATIONS"].ToString();
        Label5.Text = ds.Tables[0].Rows[0]["PATIENT_ALLERGIES_STATUS"].ToString();
        if(Label5.Text == "0")
            Label5.Text = "NA";
        else
            Label5.Text = "Yes";
        Label6.Text = ds.Tables[0].Rows[0]["PATIENT_ALLERGIES"].ToString();
        Label7.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_STATUS"].ToString();
        if(Label7.Text == "0")
            Label7.Text = "NA";
        else
            Label7.Text = "Yes";
        Label8.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_TYPE_1"].ToString();
        Label9.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_DATE_1"].ToString();
        Label10.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_TYPE_2"].ToString();
        Label11.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_DATE_2"].ToString();
        Label12.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_TYPE_3"].ToString();
        Label13.Text = ds.Tables[0].Rows[0]["PATIENT_SURGERY_DATE_3"].ToString();
        Label14.Text = ds.Tables[0].Rows[0]["PATIENT_MEDICAL_INSURANCE_STATUS"].ToString();
        if(Label14.Text == "0")
            Label14.Text = "NA";
        else
            Label14.Text = "Yes";
        Label15.Text = ds.Tables[0].Rows[0]["PATIENT_MEDICAL_INSURANCE_PROVIDER"].ToString();
        Label1.Text = ds.Tables[0].Rows[0]["PATIENT_MEDICAL_INSURANCE_POLICY_NUMBER"].ToString();
        Label16.Text = ds.Tables[0].Rows[0]["PATIENT_HEIGHT"].ToString();
        Label17.Text = ds.Tables[0].Rows[0]["PATIENT_WEIGHT"].ToString();
        Label18.Text = ds.Tables[0].Rows[0]["PATIENT_BLOOD_GROUP"].ToString();
        Label19.Text = ds.Tables[0].Rows[0]["PATIENT_DATE_OF_ADMIT"].ToString();
        Label20.Text = ds.Tables[0].Rows[0]["PATIENT_TIME_OF_ADMIT"].ToString();
        Label2.Text = ds.Tables[1].Rows[0]["FIRST_OBSERVATION_DATE"].ToString();
        Label22.Text = ds.Tables[1].Rows[0]["FIRST_OBSERVATION_TIME"].ToString();
        Label21.Text = ds.Tables[1].Rows[0]["LAST_OBSERVATION_DATE"].ToString();
        Label23.Text = ds.Tables[1].Rows[0]["LAST_OBSERVATION_TIME"].ToString();
    }
    private void GetPersonalDetailsData()
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}