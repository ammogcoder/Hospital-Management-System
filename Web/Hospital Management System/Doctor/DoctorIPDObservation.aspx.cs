using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Doctor_DoctorIPDObservation : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    public static DataSet medicineDataSet = new DataSet();
    public static DataSet medicalTestDataSet = new DataSet();
    public static int observationCount = 0;
    public static List<Doctor_IPDObservationMedicineBO> objIPDObservationMedicineBOList = new List<Doctor_IPDObservationMedicineBO>();
    public static string ipdObservationId;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        if(!Page.IsPostBack)
        {
            DropDownList4.Items.Add(new ListItem("--Select--", "0"));
            DropDownList5.Items.Add(new ListItem("--Select--", "0"));
            DropDownList6.Items.Add(new ListItem("1", "1"));
            DropDownList6.Items.Add(new ListItem("General", "0"));
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            DropDownList2.Items.Add(new ListItem("1", "1"));
            DropDownList2.Items.Add(new ListItem("General", "0"));
            FirstGridViewRow();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        reset(2);
        FirstGridViewRow();
        string patientName = TextBox1.Text;
        Doctor_SearchIPDPatientBL objDoctor_SearchIPDPatientBL = new Doctor_SearchIPDPatientBL();
        ds = objDoctor_SearchIPDPatientBL.Doctor_SearchIPDPatient(patientName, Convert.ToInt32(Session["doctorId"].ToString()));
        if(ds.Tables[0].Rows.Count == 0)
        {
            Label1.Text = "No Patient Found";
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.BackColor = System.Drawing.Color.Snow;
            GridView1.DataSource = null;
            GridView1.DataBind();
        }
        else
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Label1.Text = "";
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
        Session["patientId"] = ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();
        Session["previousWardId"] = ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString();
        Session["previousardNumber"] = ds.Tables[0].Rows[GridView1.SelectedIndex][4].ToString();
        Common_EncryptDecryptBL objCommon_EncryptDecryptBL = new Common_EncryptDecryptBL();
        string patientId = objCommon_EncryptDecryptBL.Common_Encrypt(ds.Tables[0].Rows[0][GridView1.SelectedIndex].ToString());
        string url = "DoctorViewIPDActiveMedicines.aspx";
        HyperLink1.Target = "_blank";
        HyperLink1.NavigateUrl = "javascript:void(0)";
        HyperLink1.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=1200,scrollbars');");

        url = "DoctorViewIPDObservationHistory.aspx";
        HyperLink2.Target = "_blank";
        HyperLink2.NavigateUrl = "javascript:void(0)";
        HyperLink2.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=500,scrollbars');");

        url = "DoctorViewIPDAllMedicines.aspx";
        HyperLink3.Target = "_blank";
        HyperLink3.NavigateUrl = "javascript:void(0)";
        HyperLink3.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=1200,scrollbars');");

        url = "DoctorViewIPDAllIPDObservationReports.aspx";
        HyperLink4.Target = "_blank";
        HyperLink4.NavigateUrl = "javascript:void(0)";
        HyperLink4.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=1200,scrollbars');");

        url = "DoctorViewIPDAllIPDObservationMedicalTests.aspx";
        HyperLink5.Target = "_blank";
        HyperLink5.NavigateUrl = "javascript:void(0)";
        HyperLink5.Attributes.Add("onclick", "javascript:window.open('" + url + "','','height=500,width=1200,scrollbars');");


        Panel1.Visible = true;
        ipdObservationId = Guid.NewGuid().ToString();
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void FirstGridViewRow()
    {
        DataTable dt = new DataTable();
        DataRow dr = null;
        dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));
        dt.Columns.Add(new DataColumn("Col1", typeof(string)));
        dt.Columns.Add(new DataColumn("Col2", typeof(string)));
        dt.Columns.Add(new DataColumn("Col3", typeof(string)));
        dt.Columns.Add(new DataColumn("Col4", typeof(string)));
        dt.Columns.Add(new DataColumn("Col5", typeof(string)));
        dr = dt.NewRow();
        dr["RowNumber"] = 1;
        dr["Col1"] = string.Empty;
        dr["Col2"] = string.Empty;
        dr["Col3"] = string.Empty;
        dr["Col4"] = string.Empty;
        dr["Col5"] = string.Empty;
        dt.Rows.Add(dr);

        ViewState["CurrentTable"] = dt;

        GridView2.DataSource = dt;
        GridView2.DataBind();
        TextBox txn = (TextBox)GridView2.Rows[0].Cells[1].FindControl("TextBox2");
        txn.Focus();
        Button btnAdd = (Button)GridView2.FooterRow.Cells[5].FindControl("Button2");
        Page.Form.DefaultFocus = btnAdd.ClientID;
    }

    protected void AddNewRow()
    {
        int rowIndex = 0;

        if(ViewState["CurrentTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            if(dtCurrentTable.Rows.Count > 0)
            {
                for(int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox TextBoxProblem = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("TextBox2");
                    TextBox TextBoxProblemDetail = (TextBox)GridView2.Rows[rowIndex].Cells[2].FindControl("TextBox3");
                    TextBox TextBoxSystemReview = (TextBox)GridView2.Rows[rowIndex].Cells[3].FindControl("TextBox4");
                    TextBox TextBoxAssessment = (TextBox)GridView2.Rows[rowIndex].Cells[4].FindControl("TextBox5");
                    TextBox TextBoxPlan = (TextBox)GridView2.Rows[rowIndex].Cells[5].FindControl("TextBox6");
                    DropDownList DropDownListTest = (DropDownList)GridView2.Rows[rowIndex].Cells[6].FindControl("DropDownList7");
                    
                    drCurrentRow = dtCurrentTable.NewRow();

                    dtCurrentTable.Rows[i - 1]["Col1"] = TextBoxProblem.Text;
                    dtCurrentTable.Rows[i - 1]["Col2"] = TextBoxProblemDetail.Text;
                    dtCurrentTable.Rows[i - 1]["Col3"] = TextBoxSystemReview.Text;
                    dtCurrentTable.Rows[i - 1]["Col4"] = TextBoxAssessment.Text;
                    dtCurrentTable.Rows[i - 1]["Col5"] = TextBoxPlan.Text;

                    rowIndex++;
                }
                dtCurrentTable.Rows.Add(drCurrentRow);
                ViewState["CurrentTable"] = dtCurrentTable;

                GridView2.DataSource = dtCurrentTable;
                GridView2.DataBind();
                observationCount = rowIndex;
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        SetPreviousData();
    }

    private void SetPreviousData()
    {
        int rowIndex = 0;
        if(ViewState["CurrentTable"] != null)
        {
            DataTable dt = (DataTable)ViewState["CurrentTable"];
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    TextBox TextBoxProblem = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("TextBox2");
                    TextBox TextBoxProblemDetail = (TextBox)GridView2.Rows[rowIndex].Cells[2].FindControl("TextBox3");
                    TextBox TextBoxSystemReview = (TextBox)GridView2.Rows[rowIndex].Cells[3].FindControl("TextBox4");
                    TextBox TextBoxAssessment = (TextBox)GridView2.Rows[rowIndex].Cells[4].FindControl("TextBox5");
                    TextBox TextBoxPlan = (TextBox)GridView2.Rows[rowIndex].Cells[5].FindControl("TextBox6");
                    
                    GridView2.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                    TextBoxProblem.Text = dt.Rows[i]["Col1"].ToString();
                    TextBoxProblemDetail.Text = dt.Rows[i]["Col2"].ToString();
                    TextBoxSystemReview.Text = dt.Rows[i]["Col3"].ToString();
                    TextBoxAssessment.Text = dt.Rows[i]["Col4"].ToString();
                    TextBoxPlan.Text = dt.Rows[i]["Col5"].ToString();

                    rowIndex++;
                    observationCount = rowIndex-1;
                }
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        AddNewRow();
        DropDownList6.Items.Clear();
        DropDownList2.Items.Clear();
        for(int i = 0; i < observationCount + 1; i++)
        {
            DropDownList2.Items.Add(new ListItem((i + 1).ToString(), (i + 1).ToString()));
            DropDownList6.Items.Add(new ListItem((i + 1).ToString(), (i + 1).ToString()));
        }
        DropDownList6.Items.Add(new ListItem("General", "0"));
        DropDownList2.Items.Add(new ListItem("General", "0"));
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SetRowData();
        if(ViewState["CurrentTable"] != null)
        {
            DataTable dt = (DataTable)ViewState["CurrentTable"];
            DataRow drCurrentRow = null;
            int rowIndex = Convert.ToInt32(e.RowIndex);
            Doctor_DeleteIPDObservationReportBL objDoctor_DeleteIPDObservationReportBL = new Doctor_DeleteIPDObservationReportBL();
            objDoctor_DeleteIPDObservationReportBL.Doctor_DeleteIPDObservationReport(Convert.ToInt32(e.Values["RowNumber"].ToString()));
            Doctor_GetIPDObservationMedicineBL objGetIPDObservationMedicineBL = new Doctor_GetIPDObservationMedicineBL();
            GridView3.DataSource = objGetIPDObservationMedicineBL.Doctor_GetIPDObservationMedicine(ipdObservationId);
            GridView3.DataBind();
            GridView3.Visible = true;
            if(dt.Rows.Count > 1)
            {
                dt.Rows.Remove(dt.Rows[rowIndex]);
                drCurrentRow = dt.NewRow();
                ViewState["CurrentTable"] = dt;
                GridView2.DataSource = dt;
                GridView2.DataBind();

                for(int i = 0; i < GridView2.Rows.Count - 1; i++)
                {
                    GridView2.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                }
                SetPreviousData();
            }
        }
        DropDownList6.Items.Clear();
        DropDownList2.Items.Clear();
        for(int i = 0; i < observationCount + 1; i++)
        {
            DropDownList6.Items.Add(new ListItem((i + 1).ToString(), (i + 1).ToString()));
            DropDownList2.Items.Add(new ListItem((i + 1).ToString(), (i + 1).ToString()));
        }
        DropDownList6.Items.Add(new ListItem("General", "0"));
        DropDownList2.Items.Add(new ListItem("General", "0"));
    }
    private void SetRowData()
    {
        int rowIndex = 0;

        if(ViewState["CurrentTable"] != null)
        {
            DataTable dtCurrentTable = (DataTable)ViewState["CurrentTable"];

            if(dtCurrentTable.Rows.Count > 0)
            {
                for(int i = 1; i <= dtCurrentTable.Rows.Count; i++)
                {
                    TextBox TextBoxProblem = (TextBox)GridView2.Rows[rowIndex].Cells[1].FindControl("TextBox2");
                    TextBox TextBoxProblemDetail = (TextBox)GridView2.Rows[rowIndex].Cells[2].FindControl("TextBox3");
                    TextBox TextBoxSystemReview = (TextBox)GridView2.Rows[rowIndex].Cells[3].FindControl("TextBox4");
                    TextBox TextBoxAssessment = (TextBox)GridView2.Rows[rowIndex].Cells[4].FindControl("TextBox5");
                    TextBox TextBoxPlan = (TextBox)GridView2.Rows[rowIndex].Cells[5].FindControl("TextBox6");
                    dtCurrentTable.Rows[i - 1]["Col1"] = TextBoxProblem.Text;
                    dtCurrentTable.Rows[i - 1]["Col2"] = TextBoxProblemDetail.Text;
                    dtCurrentTable.Rows[i - 1]["Col3"] = TextBoxSystemReview.Text;
                    dtCurrentTable.Rows[i - 1]["Col4"] = TextBoxAssessment.Text;
                    dtCurrentTable.Rows[i - 1]["Col5"] = TextBoxPlan.Text;
                    rowIndex++;
                }

                ViewState["CurrentTable"] = dtCurrentTable;
                GridView2.DataSource = dtCurrentTable;
                GridView2.DataBind();
            }
        }
        else
        {
            Response.Write("ViewState is null");
        }
        //SetPreviousData();
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList5.Items.Clear();
        DropDownList5.Items.Add(new ListItem("--Select--", "0"));
        int medicineType = Convert.ToInt32(DropDownList4.SelectedValue);
        Doctor_GetMedicineNameByTypeBL objGetMedicineNameByTypeBL = new Doctor_GetMedicineNameByTypeBL();
        DropDownList5.DataSource = objGetMedicineNameByTypeBL.Doctor_GetMedicineNameByType(medicineType);
        DropDownList5.DataTextField = "MEDICINE_NAME";
        DropDownList5.DataValueField = "ID";
        DropDownList5.DataBind();
    }
    protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        DataTable table = ViewState["CurrentTable"] as DataTable;
        foreach(GridViewRow row in GridView2.Rows)
        {
            int ipdObservationReportId = Convert.ToInt32(row.Cells[0].Text);
            TextBox TextBoxProblem = row.FindControl("TextBox2") as TextBox;
            TextBox TextBoxProblemDetail = row.FindControl("TextBox3") as TextBox;
            TextBox TextBoxSystemReview = row.FindControl("TextBox4") as TextBox;
            TextBox TextBoxAssessment = row.FindControl("TextBox5") as TextBox;
            TextBox TextBoxPlan = row.FindControl("TextBox6") as TextBox;
            string problem = TextBoxProblem.Text;
            string problemDetails = TextBoxProblemDetail.Text;
            string systemReview = TextBoxSystemReview.Text;
            string assessment = TextBoxAssessment.Text;
            string plan = TextBoxPlan.Text;

            Doctor_AddIPDObservationReportBL objDoctor_AddIPDObservationReportBL = new Doctor_AddIPDObservationReportBL();
            objDoctor_AddIPDObservationReportBL.Doctor_AddIPDObservationReport(ipdObservationReportId, ipdObservationId, problem,
                problemDetails, systemReview, assessment, plan);
            Panel1.Visible = false;
            Label1.Text = "IPD Observation Submitted";
            Label1.ForeColor = System.Drawing.Color.Black;
            Label1.BackColor = System.Drawing.Color.Yellow;
            GridView1.DataSource = null;
            GridView1.DataBind();
        }

        int doctorId = Convert.ToInt32(Session["doctorId"].ToString());
        int patientId = Convert.ToInt32(ds.Tables[0].Rows[0][GridView1.SelectedIndex].ToString());
        string observationDate = DateTime.ParseExact(TextBox8.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string observationTime = TextBox9.Text;
        int patientHealthCondition = Convert.ToInt32(RadioButtonList1.SelectedValue);
        int transferToDoctorId = -1;
        if(Session["transferToDoctorId"] != null)
            transferToDoctorId = Convert.ToInt32(Session["transferToDoctorId"].ToString());
        int wardTransferId = -1;
        if(Session["wardTransferId"] != null)
            wardTransferId = Convert.ToInt32(Session["wardTransferId"].ToString());

        Doctor_AddIPDObservationBL objDoctor_AddIPDObservationBL = new Doctor_AddIPDObservationBL();
        objDoctor_AddIPDObservationBL.Doctor_AddIPDObservation(ipdObservationId, doctorId, patientId,
            observationDate, observationTime, patientHealthCondition, transferToDoctorId,
            wardTransferId);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {        
        int ipdObservationReportId = Convert.ToInt32(DropDownList6.SelectedValue);
        int medicineTypeId = Convert.ToInt32(DropDownList4.SelectedValue);
        int medicineNameId = Convert.ToInt32(DropDownList5.SelectedValue);
        string medicineStrength = TextBox7.Text;
        string medicineQuantity = TextBox4.Text;
        string medicineStartDate = DateTime.ParseExact(TextBox5.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        int numberOfRefills = Convert.ToInt32(TextBox2.Text);
        string quantityOnRefills = TextBox6.Text;
        string medicineInstructions = TextBox3.Text;

        Doctor_IPDObservationMedicineBO objIPDObservationMedicineBO = new Doctor_IPDObservationMedicineBO();
        objIPDObservationMedicineBO.ipdObservationReportId = ipdObservationReportId;
        objIPDObservationMedicineBO.medicineInstructions = medicineInstructions;
        objIPDObservationMedicineBO.medicineType = DropDownList4.SelectedItem.Text;
        objIPDObservationMedicineBO.medicineName = DropDownList5.SelectedItem.Text;
        objIPDObservationMedicineBO.medicineStrength = TextBox1.Text;
        objIPDObservationMedicineBO.medicineQuantity = TextBox4.Text;
        objIPDObservationMedicineBO.medicineStartDate = TextBox5.Text;
        objIPDObservationMedicineBO.numberOfRefills = Convert.ToInt32(TextBox2.Text);
        objIPDObservationMedicineBO.quantityOnRefills = TextBox6.Text;
        objIPDObservationMedicineBO.medicineInstructions = TextBox3.Text;

        objIPDObservationMedicineBOList.Add(objIPDObservationMedicineBO);

        Doctor_AddIPDObservationMedicineBL objDoctor_AddIPDObservationMedicineBL = new Doctor_AddIPDObservationMedicineBL();
        objDoctor_AddIPDObservationMedicineBL.Doctor_AddIPDObservationMedicine(ipdObservationId, ipdObservationReportId,
            medicineTypeId, medicineNameId, medicineStrength, medicineQuantity, medicineStartDate, 
            numberOfRefills, quantityOnRefills, medicineInstructions);

        GetMedicines();
        reset(1);
    }
    protected void reset(int flag)
    {
        if(flag==1)
        {
            DropDownList2.SelectedIndex = DropDownList6.SelectedIndex = DropDownList4.SelectedIndex = DropDownList5.SelectedIndex = 0;
            TextBox7.Text = TextBox4.Text = TextBox5.Text = TextBox2.Text = TextBox6.Text = TextBox3.Text = "";
        }
        if(flag==2)
        {
            DropDownList6.Items.Clear();
            DropDownList6.Items.Add(new ListItem("1", "1"));
            DropDownList6.Items.Add(new ListItem("General", "0"));
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add(new ListItem("1", "1"));
            DropDownList2.Items.Add(new ListItem("General", "0"));
            Panel1.Visible = Panel2.Visible = false;
            GridView3.DataSource = null;
            GridView3.DataBind();
            TextBox9.Text = "";
            RadioButtonList1.ClearSelection();
            DropDownList2.SelectedIndex = DropDownList6.SelectedIndex = DropDownList4.SelectedIndex = DropDownList5.SelectedIndex = 0;
            TextBox7.Text = TextBox4.Text = TextBox5.Text = TextBox2.Text = TextBox6.Text = TextBox3.Text = "";
        }
        if(flag == 3)
        {
            DropDownList2.SelectedIndex = DropDownList1.SelectedIndex = 0;
            TextBox10.Text = TextBox11.Text = TextBox12.Text = "";
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        reset(1);
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        reset(3);
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        int ipdObservationReportId = Convert.ToInt32(DropDownList2.SelectedValue);
        int medicalTestId = Convert.ToInt32(DropDownList1.SelectedValue);
        string medicalTestDate = DateTime.ParseExact(TextBox10.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        string medicalTestTime = TextBox11.Text;
        string remarks = TextBox12.Text;

        Doctor_AddIPDObservationMedicalTestBL objDoctor_AddIPDObservationMedicalTestBL = new Doctor_AddIPDObservationMedicalTestBL();
        objDoctor_AddIPDObservationMedicalTestBL.Doctor_AddIPDObservationMedicalTest(ipdObservationId, ipdObservationReportId,
            medicalTestId, medicalTestDate, medicalTestTime, remarks);

        GetMedicalTests();
        reset(3);
    }
    protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView4_SelectedIndexChanged(object sender, EventArgs e)
    {       
        int ipdObservationMedicalTestId=Convert.ToInt32(medicalTestDataSet.Tables[0].Rows[GridView4.SelectedIndex][0].ToString());
        Doctor_DeleteIPDObservationMedicalTestBL objDoctor_DeleteIPDObservationMedicalTestBL = new Doctor_DeleteIPDObservationMedicalTestBL();
        objDoctor_DeleteIPDObservationMedicalTestBL.Doctor_DeleteIPDObservationMedicalTest(ipdObservationMedicalTestId);
        GetMedicalTests();
        reset(3);
    }
    private void GetMedicalTests()
    {
        Doctor_GetIPDObservationMedicalTestBL objDoctor_GetIPDObservationMedicalTestBL = new Doctor_GetIPDObservationMedicalTestBL();
        medicalTestDataSet = objDoctor_GetIPDObservationMedicalTestBL.Doctor_GetIPDObservationMedicalTest(ipdObservationId);
        if(medicalTestDataSet.Tables[0].Rows.Count != 0)
        {
            GridView4.DataSource = medicalTestDataSet;
            GridView4.DataBind();
            Panel3.Visible = true;
        }
        else
            Panel3.Visible = false;
    }
    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        int ipdObservationMedicineId = Convert.ToInt32(medicineDataSet.Tables[0].Rows[GridView3.SelectedIndex][0].ToString());
        Doctor_DeleteIPDObservationMedicineBL objDoctor_DeleteIPDObservationMedicineBL = new Doctor_DeleteIPDObservationMedicineBL();
        objDoctor_DeleteIPDObservationMedicineBL.Doctor_DeleteIPDObservationMedicine(ipdObservationMedicineId);
        GetMedicines();
        reset(1);
    }
    private void GetMedicines()
    {
        Doctor_GetIPDObservationMedicineBL objGetIPDObservationMedicineBL = new Doctor_GetIPDObservationMedicineBL();
        medicineDataSet = objGetIPDObservationMedicineBL.Doctor_GetIPDObservationMedicine(ipdObservationId);
        if(medicineDataSet.Tables[0].Rows.Count != 0)
        {
            GridView3.DataSource = medicineDataSet;
            GridView3.DataBind();
            GridView3.Visible = true;
            Panel2.Visible = true;
        }
        else
        {
            GridView3.Visible = false;
            Panel2.Visible = false;
        }
    }
}