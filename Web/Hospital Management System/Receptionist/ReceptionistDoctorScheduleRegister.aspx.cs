using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistAttendanceRegister : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string doctorName = TextBox1.Text;
        SearchDoctorBL objSearchDoctorBL = new SearchDoctorBL();
        ds = objSearchDoctorBL.SearchDoctor(doctorName);
        if(ds.Tables[0].Rows.Count == 0)
            Label1.Visible = true;
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
        int doctorId = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString());
        Response.Write(@"<script language=""javascript"">window.open('ReceptionistViewDoctorSchedule.aspx?doctorId=" + doctorId.ToString() + "', '_blank', 'height=500,width=700,scrollbars')</script>");
    }
}