using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorDailySchedule : System.Web.UI.Page
{
    public static int leaveId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            int empId = Convert.ToInt32(Session["doctorId"].ToString());

            Common_GetEmployeeScheduleBL objGetEmployeeScheduleBL = new Common_GetEmployeeScheduleBL();
            DataSet ds = new DataSet();
            ds = objGetEmployeeScheduleBL.Common_GetEmployeeSchedule(empId);
            Label1.Text = ds.Tables[0].Rows[0]["MON_SESS1_FROM"].ToString();
            Label2.Text = ds.Tables[0].Rows[0]["MON_SESS1_TO"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["MON_SESS2_FROM"].ToString();
            Label4.Text = ds.Tables[0].Rows[0]["MON_SESS2_TO"].ToString();
            Label5.Text = ds.Tables[0].Rows[0]["MON_SESS3_FROM"].ToString();
            Label6.Text = ds.Tables[0].Rows[0]["MON_SESS3_TO"].ToString();
            Label7.Text = ds.Tables[0].Rows[0]["TUE_SESS1_FROM"].ToString();
            Label8.Text = ds.Tables[0].Rows[0]["TUE_SESS1_TO"].ToString();
            Label9.Text = ds.Tables[0].Rows[0]["TUE_SESS2_FROM"].ToString();
            Label10.Text = ds.Tables[0].Rows[0]["TUE_SESS2_TO"].ToString();
            Label11.Text = ds.Tables[0].Rows[0]["TUE_SESS3_FROM"].ToString();
            Label12.Text = ds.Tables[0].Rows[0]["TUE_SESS3_TO"].ToString();
            Label13.Text = ds.Tables[0].Rows[0]["WED_SESS1_FROM"].ToString();
            Label14.Text = ds.Tables[0].Rows[0]["WED_SESS1_TO"].ToString();
            Label15.Text = ds.Tables[0].Rows[0]["WED_SESS2_FROM"].ToString();
            Label16.Text = ds.Tables[0].Rows[0]["WED_SESS2_TO"].ToString();
            Label17.Text = ds.Tables[0].Rows[0]["WED_SESS3_FROM"].ToString();
            Label18.Text = ds.Tables[0].Rows[0]["WED_SESS3_TO"].ToString();
            Label19.Text = ds.Tables[0].Rows[0]["THU_SESS1_FROM"].ToString();
            Label20.Text = ds.Tables[0].Rows[0]["THU_SESS1_TO"].ToString();
            Label21.Text = ds.Tables[0].Rows[0]["THU_SESS2_FROM"].ToString();
            Label22.Text = ds.Tables[0].Rows[0]["THU_SESS2_TO"].ToString();
            Label23.Text = ds.Tables[0].Rows[0]["THU_SESS3_FROM"].ToString();
            Label24.Text = ds.Tables[0].Rows[0]["THU_SESS3_TO"].ToString();
            Label25.Text = ds.Tables[0].Rows[0]["FRI_SESS1_FROM"].ToString();
            Label26.Text = ds.Tables[0].Rows[0]["FRI_SESS1_TO"].ToString();
            Label27.Text = ds.Tables[0].Rows[0]["FRI_SESS2_FROM"].ToString();
            Label28.Text = ds.Tables[0].Rows[0]["FRI_SESS2_TO"].ToString();
            Label29.Text = ds.Tables[0].Rows[0]["FRI_SESS3_FROM"].ToString();
            Label30.Text = ds.Tables[0].Rows[0]["FRI_SESS3_TO"].ToString();
            Label31.Text = ds.Tables[0].Rows[0]["SAT_SESS1_FROM"].ToString();
            Label32.Text = ds.Tables[0].Rows[0]["SAT_SESS1_TO"].ToString();
            Label33.Text = ds.Tables[0].Rows[0]["SAT_SESS2_FROM"].ToString();
            Label34.Text = ds.Tables[0].Rows[0]["SAT_SESS2_TO"].ToString();
            Label35.Text = ds.Tables[0].Rows[0]["SAT_SESS3_FROM"].ToString();
            Label36.Text = ds.Tables[0].Rows[0]["SAT_SESS3_TO"].ToString();
            Label37.Text = ds.Tables[0].Rows[0]["SUN_SESS1_FROM"].ToString();
            Label38.Text = ds.Tables[0].Rows[0]["SUN_SESS1_TO"].ToString();
            Label39.Text = ds.Tables[0].Rows[0]["SUN_SESS2_FROM"].ToString();
            Label40.Text = ds.Tables[0].Rows[0]["SUN_SESS2_TO"].ToString();
            Label41.Text = ds.Tables[0].Rows[0]["SUN_SESS3_FROM"].ToString();
            Label42.Text = ds.Tables[0].Rows[0]["SUN_SESS3_TO"].ToString();


            Common_GetDoctorAppointmentsByIdBL objGetDoctorAppointmentsByIdBL = new Common_GetDoctorAppointmentsByIdBL();
            GridView1.DataSource = objGetDoctorAppointmentsByIdBL.Common_GetDoctorAppointmentsById(Convert.ToInt32(Session["doctorId"].ToString()));
            GridView1.DataBind();

            GetEmployeeLeaveBL objGetEmployeeLeaveBL = new GetEmployeeLeaveBL();
            ds = objGetEmployeeLeaveBL.GetEmployeeLeave(empId);
            if(ds.Tables[0].Rows.Count != 0)
            {
                leaveId = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"].ToString());
                string leaveFromDate = ds.Tables[0].Rows[0]["FROM_DATE"].ToString();
                string leaveToDate = ds.Tables[0].Rows[0]["TO_DATE"].ToString();
                string leaveFromTime = ds.Tables[0].Rows[0]["FROM_TIME"].ToString();
                string leaveToTime = ds.Tables[0].Rows[0]["TO_TIME"].ToString();
                Label43.Text = "On Leave From " + leaveFromTime + " " + leaveFromDate + " to " + leaveToTime + " " + leaveToDate;
                LinkButton1.Visible = true;
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Common_CancelEmployeeLeaveBL objCommon_CancelEmployeeLeaveBL = new Common_CancelEmployeeLeaveBL();
        objCommon_CancelEmployeeLeaveBL.Common_CancelEmployeeLeave(Convert.ToInt32(Session["doctorId"].ToString()), leaveId);
        LinkButton1.Visible = false;
        Label43.Text = "Leave Cancelled";
    }
}