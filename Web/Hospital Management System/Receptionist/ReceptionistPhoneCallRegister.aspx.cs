using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistPhoneCallRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        getPhoneCalls();
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
            Panel1.Visible = true;
        else
        {
            Panel1.Visible = false;
            getPhoneCalls();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int empId = Convert.ToInt32(Session["receptionistId"].ToString());
        string fromDate = DateTime.ParseExact(TextBox1.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string toDate = DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        int callType = Convert.ToInt32(DropDownList1.SelectedIndex);

        switch (callType)
        {
            case 1:
                FilterGeneralInquiryPhoneCallBL objFilterGeneralInquiryPhoneCallBL = new FilterGeneralInquiryPhoneCallBL();
                GridView1.DataSource = objFilterGeneralInquiryPhoneCallBL.FilterGeneralInquiryPhoneCall(empId, fromDate, toDate);
                GridView1.DataBind();
                MultiView1.ActiveViewIndex = 0;
                break;

            case 2:
                FilterEmergencyPhoneCallBL objFilterEmergencyPhoneCallBL = new FilterEmergencyPhoneCallBL();
                GridView2.DataSource = objFilterEmergencyPhoneCallBL.FilterEmergencyPhoneCall(empId, fromDate, toDate);
                GridView2.DataBind();
                MultiView1.ActiveViewIndex = 1;
                break;

            case 3:
                FilterForwardPhoneCallBL objFilterForwardPhoneCallBL = new FilterForwardPhoneCallBL();
                GridView3.DataSource = objFilterForwardPhoneCallBL.FilterForwardPhoneCall(empId, fromDate, toDate);
                GridView3.DataBind();
                MultiView1.ActiveViewIndex = 2;
                break;

            case 4:
                FilterMessagePhoneCallBL objFilterMessagePhoneCallBL = new FilterMessagePhoneCallBL();
                GridView4.DataSource = objFilterMessagePhoneCallBL.FilterMessagePhoneCall(empId, fromDate, toDate);
                GridView4.DataBind();
                MultiView1.ActiveViewIndex = 3;
                break;

            case 5:
                MultiView1.ActiveViewIndex = 4;
                break;
        }
    }
    protected void getPhoneCalls()
    {
        int callType = Convert.ToInt32(DropDownList1.SelectedIndex);
        int empId = Convert.ToInt32(Session["receptionistId"].ToString());

        switch (callType)
        {
            case 1:
                GetPhoneCallGeneralInquiryBL objGetPhoneCallGeneralInquiryBL = new GetPhoneCallGeneralInquiryBL();
                GridView1.DataSource = objGetPhoneCallGeneralInquiryBL.GetPhoneCallGeneralInquiry(empId);
                GridView1.DataBind();
                MultiView1.ActiveViewIndex = 0;
                break;

            case 2:
                GetPhoneCallEmergencyBL objGetPhoneCallEmergencyBL = new GetPhoneCallEmergencyBL();
                GridView2.DataSource = objGetPhoneCallEmergencyBL.GetPhoneCallEmergency(empId);
                GridView2.DataBind();
                MultiView1.ActiveViewIndex = 1;
                break;

            case 3:
                GetPhoneCallForwardBL objGetPhoneCallForwardBL = new GetPhoneCallForwardBL();
                GridView3.DataSource = objGetPhoneCallForwardBL.GetPhoneCallForward(empId);
                GridView3.DataBind();
                MultiView1.ActiveViewIndex = 2;
                break;

            case 4:
                GetPhoneCallMessageBL objGetPhoneCallMessageBL = new GetPhoneCallMessageBL();
                GridView4.DataSource = objGetPhoneCallMessageBL.GetPhoneCallMessage(empId);
                GridView4.DataBind();
                MultiView1.ActiveViewIndex = 3;
                break;

            case 5:
                MultiView1.ActiveViewIndex = 4;
                break;
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
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
}