using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistWardCharges : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            getWardCharges();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string suiteWardCharge = TextBox1.Text;
        string deluxeWardCharge = TextBox2.Text;
        string specialAcWardCharge = TextBox3.Text;
        string semiWardPrivate = TextBox4.Text;
        string generalWardCharge = TextBox5.Text;

        SetWardChargeBL objSetWardChargeBL = new SetWardChargeBL();
        objSetWardChargeBL.SetWardCharge(suiteWardCharge, deluxeWardCharge, specialAcWardCharge, semiWardPrivate, generalWardCharge);
        Label16.Text = "Ward Charges Updated";
        getWardCharges();
    }

    protected void getWardCharges()
    {
        GetWardChargeBL objGetWardChargeBL = new GetWardChargeBL();
        DataSet ds = objGetWardChargeBL.GetWardCharge();
        Label6.Text = Label1.Text = ds.Tables[0].Rows[0]["WARD_NAME"].ToString();
        Label8.Text = Label2.Text = ds.Tables[0].Rows[1]["WARD_NAME"].ToString();
        Label10.Text = Label3.Text = ds.Tables[0].Rows[2]["WARD_NAME"].ToString();
        Label12.Text = Label4.Text = ds.Tables[0].Rows[3]["WARD_NAME"].ToString();
        Label14.Text = Label5.Text = ds.Tables[0].Rows[4]["WARD_NAME"].ToString();
        TextBox1.Text = Label7.Text = ds.Tables[0].Rows[0]["WARD_CHARGE"].ToString();
        TextBox2.Text = Label9.Text = ds.Tables[0].Rows[1]["WARD_CHARGE"].ToString();
        TextBox3.Text = Label11.Text = ds.Tables[0].Rows[2]["WARD_CHARGE"].ToString();
        TextBox4.Text = Label13.Text = ds.Tables[0].Rows[3]["WARD_CHARGE"].ToString();
        TextBox5.Text = Label15.Text = ds.Tables[0].Rows[4]["WARD_CHARGE"].ToString();
    }
}