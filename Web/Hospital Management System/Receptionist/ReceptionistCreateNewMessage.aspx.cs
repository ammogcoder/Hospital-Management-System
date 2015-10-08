using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistCreateNewMessage : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            Button3.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*int senderId = Convert.ToInt32(Session["empId"].ToString());
        int receiverId = Convert.ToInt32(DropDownList1.SelectedValue);
        string messageSubject = TextBox1.Text;
        string messageContent = TextBox2.Text;

        CreateNewMessageBL objCreateNewMessageBL = new CreateNewMessageBL();
        objCreateNewMessageBL.CreateNewMessage(senderId, messageSubject, receiverId, messageContent);
        Label1.Text = "Message Sent";
        TextBox1.Text = "";
        TextBox2.Text = "";
        DropDownList1.SelectedIndex = 0;*/
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        ModalPopupExtender1.Show();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ModalPopupExtender1.Hide();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ModalPopupExtender1.Show();
        Common_DoctorByDepartmentBL objDoctorByDepartmentBL = new Common_DoctorByDepartmentBL();
        ds = objDoctorByDepartmentBL.Common_DoctorByDepartment(Convert.ToInt32(DropDownList1.SelectedValue));
        GridView1.DataSource = ds;
        GridView1.DataBind();
        if(ds.Tables[0].Rows.Count == 0)
            Button3.Visible = false;
        Button3.Visible = true;
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
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string doctorName = null;
        foreach(GridViewRow row in GridView1.Rows)
        {
            if(row.RowType == DataControlRowType.DataRow)
            {
                 CheckBox cb = (row.Cells[0].FindControl("CheckBox1") as CheckBox);
                 if(cb.Checked)
                 {
                     doctorName = ds.Tables[0].Rows[GridView1.SelectedIndex][2].ToString();
                 }
            }
        }
        Label2.Text = doctorName;
        ModalPopupExtender1.Hide();
    }
}