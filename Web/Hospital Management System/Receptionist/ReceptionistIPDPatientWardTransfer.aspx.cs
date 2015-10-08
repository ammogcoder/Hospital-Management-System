using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistSearchIPDPatientForWardTransfer : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        searchPatient();
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            Panel1.Visible = false;
            Label1.Text = "No Patient Found";
            Label1.BackColor = System.Drawing.Color.Snow;
            Label1.Visible = true;
            Label1.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            Panel1.Visible = false;
            Label1.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Label3.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString();
        Label5.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][2].ToString();
        Label8.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][3].ToString();
        Label11.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][4].ToString();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Panel1.Visible = false;
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add(new ListItem("--Select--", "0"));
        int wardId = Convert.ToInt32(DropDownList1.SelectedValue);
        GetWardNumberBL objGetWardNumberBL = new GetWardNumberBL();
        DataSet ds = objGetWardNumberBL.GetWardNumber(wardId);
        DropDownList2.DataTextField = "WARD_NUMBER";
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int patientId = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString());
        int previousWardId = Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][5].ToString());
        int previousardNumber = Convert.ToInt32(Label8.Text);
        string transferDate = DateTime.ParseExact(TextBox3.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string transferTime = TextBox4.Text;
        string reasonForTransfer = TextBox2.Text;
        int newWardId = Convert.ToInt32(DropDownList1.SelectedValue);
        int newWardNumber = Convert.ToInt32(DropDownList2.Text);

        Common_PatientWardTransferBL objPatientWardTransferBL = new Common_PatientWardTransferBL();
        objPatientWardTransferBL.Common_PatientWardTransfer(patientId, previousWardId, previousardNumber, transferDate, transferTime, reasonForTransfer, newWardId, newWardNumber, Convert.ToInt32(Session["receptionistId"].ToString()));
        Label1.Text = "Patient Transferred";
        Label1.BackColor = System.Drawing.Color.Yellow;
        Label1.Visible = true;
        Label1.ForeColor = System.Drawing.Color.Black;
        Panel1.Visible = false;
        searchPatient();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
    }
    protected void searchPatient()
    {
        string patientName = TextBox1.Text;
        Receptionist_SearchIPDPatientBL objSearchPatientBL = new Receptionist_SearchIPDPatientBL();
        ds = objSearchPatientBL.Receptionist_SearchIPDPatient(patientName);
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
}