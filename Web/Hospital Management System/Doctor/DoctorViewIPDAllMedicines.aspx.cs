using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorViewIPDAllMedicines : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    public static int patientId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            patientId = Convert.ToInt32(Session["patientId"].ToString());
            Doctor_GetIPDAllMedicinesBL objDoctor_GetIPDAllMedicinesBL = new Doctor_GetIPDAllMedicinesBL();
            ds = objDoctor_GetIPDAllMedicinesBL.Doctor_GetIPDAllMedicines(patientId, Convert.ToInt32(Session["doctorId"].ToString()));
            if(ds.Tables[0].Rows.Count != 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                Label1.Visible = true;
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
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Doctor_ChangeIPDMedicineStatusBL objDoctor_ChangeIPDMedicineStatusBL = new Doctor_ChangeIPDMedicineStatusBL();
        if(ds.Tables[0].Rows[GridView1.SelectedIndex][10].ToString() == "Inactive")
            objDoctor_ChangeIPDMedicineStatusBL.Doctor_ChangeIPDMedicineStatus(Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString()), 1);
        else
            objDoctor_ChangeIPDMedicineStatusBL.Doctor_ChangeIPDMedicineStatus(Convert.ToInt32(ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString()), 0);
        Doctor_GetIPDAllMedicinesBL objDoctor_GetIPDAllMedicinesBL = new Doctor_GetIPDAllMedicinesBL();
        ds = objDoctor_GetIPDAllMedicinesBL.Doctor_GetIPDAllMedicines(Convert.ToInt32(patientId), Convert.ToInt32(Session["doctorId"].ToString()));
        if(ds.Tables[0].Rows.Count != 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            Label1.Visible = true;
        }
    }
}