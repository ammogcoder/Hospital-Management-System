using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistWardDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["wardId"] != null && Request.QueryString["wardNumber"] != null)
        {
            int wardId = Convert.ToInt32(Request.QueryString["wardId"].ToString());
            int wardNumber = Convert.ToInt32(Request.QueryString["wardNumber"].ToString());

            GetRoomDetailsBL objGetRoomDetailsBL = new GetRoomDetailsBL();
            DataSet ds = objGetRoomDetailsBL.GetRoomDetails(wardId, wardNumber);
            if (ds.Tables[0].Rows.Count != 0)
            {
                Panel1.Visible = true;
                Label1.Text = ds.Tables[0].Rows[0]["PATIENT_NAME"].ToString();
                Label2.Text = ds.Tables[0].Rows[0]["PATIENT_GENDER"].ToString();
                Label3.Text = ds.Tables[0].Rows[0]["PATIENT_DOB"].ToString();
                Label4.Text = ds.Tables[0].Rows[0]["PATIENT_PRIMARY_ADDRESS"].ToString();
                Label5.Text = ds.Tables[0].Rows[0]["PATIENT_PRIMARY_PHONE"].ToString();
                Label6.Text = ds.Tables[0].Rows[0]["PATIENT_EMAIL"].ToString();
                if (Label6.Text == "")
                    Label6.Text = "NA";
                Label8.Text = ds.Tables[0].Rows[0]["EMPLOYEE_NAME"].ToString();
                Label9.Text = ds.Tables[0].Rows[0]["PATIENT_DATE_OF_ADMIT"].ToString();
                Label10.Text = ds.Tables[0].Rows[0]["PATIENT_TIME_OF_ADMIT"].ToString();
                Label11.Text = ds.Tables[0].Rows[0]["PATIENT_REMARK"].ToString();
                Label13.Text = ds.Tables[0].Rows[0]["CASE_ID_FK"].ToString();
            }
            else
                Panel1.Visible = false;
        }
    }
}