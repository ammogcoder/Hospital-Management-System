using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistViewAllPatientInfo : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string patientName = TextBox1.Text;
        Receptionist_SearchIPDPatientBL objSearchPatientBL = new Receptionist_SearchIPDPatientBL();
        ds = objSearchPatientBL.Receptionist_SearchIPDPatient(patientName);
        if(ds.Tables[0].Rows.Count == 0)
        {
            Label1.Visible = true;
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
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[0].Visible = false;
        if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int wardId = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString());
        int wardNumber = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][4].ToString());
        string url = "ReceptionistRoomDetails.aspx?wardId=" + wardId + "&wardNumber=" + wardNumber;
        string script = "window.open('" + url + "', '_blank', 'width=600, height=500');";
        ClientScript.RegisterStartupScript(this.GetType(), "script", script, true);
    }
}