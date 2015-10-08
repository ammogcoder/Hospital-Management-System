using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Receptionist_ReceptionistOPDMedicalTest : System.Web.UI.Page
{
    public static DataSet ds = new DataSet();
    public static DataSet ds1 = new DataSet();
    public static List<string> medicalTestList = new List<string>();
    public static int opdMedicalTestRegistrationId;
    public static string testDate;
    public static string testTime;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            GetMedicalTestChargesBL objGetMedicalTestChargesBL = new GetMedicalTestChargesBL();
            ds1 = objGetMedicalTestChargesBL.GetMedicalTestCharges();
            Label5.Text = "Rs. " + ds1.Tables[0].Rows[0]["MEDICAL_TEST_CHARGE"].ToString();
            Label6.Text = "Rs. " + ds1.Tables[0].Rows[1]["MEDICAL_TEST_CHARGE"].ToString();
            Label7.Text = "Rs. " + ds1.Tables[0].Rows[2]["MEDICAL_TEST_CHARGE"].ToString();
            Label8.Text = "Rs. " + ds1.Tables[0].Rows[3]["MEDICAL_TEST_CHARGE"].ToString();
            Label9.Text = "Rs. " + ds1.Tables[0].Rows[4]["MEDICAL_TEST_CHARGE"].ToString();
            Label10.Text = "Rs. " + ds1.Tables[0].Rows[5]["MEDICAL_TEST_CHARGE"].ToString();
            Label11.Text = "Rs. " + ds1.Tables[0].Rows[6]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox1.Attributes.Add("Value", ds1.Tables[0].Rows[6]["ID"].ToString());
            Label12.Text = "Rs. " + ds1.Tables[0].Rows[7]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox2.Attributes.Add("Value", ds1.Tables[0].Rows[7]["ID"].ToString());
            Label13.Text = "Rs. " + ds1.Tables[0].Rows[8]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox3.Attributes.Add("Value", ds1.Tables[0].Rows[8]["ID"].ToString());
            Label14.Text = "Rs. " + ds1.Tables[0].Rows[9]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox4.Attributes.Add("Value", ds1.Tables[0].Rows[9]["ID"].ToString());
            Label15.Text = "Rs. " + ds1.Tables[0].Rows[10]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox5.Attributes.Add("Value", ds1.Tables[0].Rows[10]["ID"].ToString());
            Label16.Text = "Rs. " + ds1.Tables[0].Rows[11]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox6.Attributes.Add("Value", ds1.Tables[0].Rows[11]["ID"].ToString());
            Label17.Text = "Rs. " + ds1.Tables[0].Rows[12]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox7.Attributes.Add("Value", ds1.Tables[0].Rows[12]["ID"].ToString());
            Label18.Text = "Rs. " + ds1.Tables[0].Rows[13]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox8.Attributes.Add("Value", ds1.Tables[0].Rows[13]["ID"].ToString());
            Label19.Text = "Rs. " + ds1.Tables[0].Rows[14]["MEDICAL_TEST_CHARGE"].ToString();
            CheckBox9.Attributes.Add("Value", ds1.Tables[0].Rows[14]["ID"].ToString());
            Label20.Text = ds1.Tables[0].Rows[15]["MEDICAL_TEST"].ToString();
            CheckBox10.Attributes.Add("Value", ds1.Tables[0].Rows[15]["ID"].ToString());
            Label32.Text = "Rs. " + ds1.Tables[0].Rows[15]["MEDICAL_TEST_CHARGE"].ToString();
            Label21.Text = ds1.Tables[0].Rows[16]["MEDICAL_TEST"].ToString();
            CheckBox11.Attributes.Add("Value", ds1.Tables[0].Rows[16]["ID"].ToString());
            Label33.Text = "Rs. " + ds1.Tables[0].Rows[16]["MEDICAL_TEST_CHARGE"].ToString();
            Label22.Text = ds1.Tables[0].Rows[17]["MEDICAL_TEST"].ToString();
            CheckBox12.Attributes.Add("Value", ds1.Tables[0].Rows[17]["ID"].ToString());
            Label34.Text = "Rs. " + ds1.Tables[0].Rows[17]["MEDICAL_TEST_CHARGE"].ToString();
            Label23.Text = ds1.Tables[0].Rows[18]["MEDICAL_TEST"].ToString();
            CheckBox13.Attributes.Add("Value", ds1.Tables[0].Rows[18]["ID"].ToString());
            Label35.Text = "Rs. " + ds1.Tables[0].Rows[18]["MEDICAL_TEST_CHARGE"].ToString();
            Label24.Text = ds1.Tables[0].Rows[19]["MEDICAL_TEST"].ToString();
            CheckBox14.Attributes.Add("Value", ds1.Tables[0].Rows[19]["ID"].ToString());
            Label36.Text = "Rs. " + ds1.Tables[0].Rows[19]["MEDICAL_TEST_CHARGE"].ToString();
            Label25.Text = ds1.Tables[0].Rows[20]["MEDICAL_TEST"].ToString();
            CheckBox15.Attributes.Add("Value", ds1.Tables[0].Rows[20]["ID"].ToString());
            Label37.Text = "Rs. " + ds1.Tables[0].Rows[20]["MEDICAL_TEST_CHARGE"].ToString();
            Label26.Text = ds1.Tables[0].Rows[21]["MEDICAL_TEST"].ToString();
            CheckBox16.Attributes.Add("Value", ds1.Tables[0].Rows[21]["ID"].ToString());
            Label38.Text = "Rs. " + ds1.Tables[0].Rows[21]["MEDICAL_TEST_CHARGE"].ToString();
            Label27.Text = ds1.Tables[0].Rows[22]["MEDICAL_TEST"].ToString();
            CheckBox17.Attributes.Add("Value", ds1.Tables[0].Rows[22]["ID"].ToString());
            Label39.Text = "Rs. " + ds1.Tables[0].Rows[22]["MEDICAL_TEST_CHARGE"].ToString();
            Label28.Text = ds1.Tables[0].Rows[23]["MEDICAL_TEST"].ToString();
            CheckBox18.Attributes.Add("Value", ds1.Tables[0].Rows[23]["ID"].ToString());
            Label40.Text = "Rs. " + ds1.Tables[0].Rows[23]["MEDICAL_TEST_CHARGE"].ToString();
            Label29.Text = ds1.Tables[0].Rows[24]["MEDICAL_TEST"].ToString();
            CheckBox19.Attributes.Add("Value", ds1.Tables[0].Rows[24]["ID"].ToString());
            Label41.Text = "Rs. " + ds1.Tables[0].Rows[24]["MEDICAL_TEST_CHARGE"].ToString();
            Label30.Text = ds1.Tables[0].Rows[25]["MEDICAL_TEST"].ToString();
            CheckBox20.Attributes.Add("Value", ds1.Tables[0].Rows[25]["ID"].ToString());
            Label42.Text = "Rs. " + ds1.Tables[0].Rows[25]["MEDICAL_TEST_CHARGE"].ToString();
            Label31.Text = ds1.Tables[0].Rows[26]["MEDICAL_TEST"].ToString();
            CheckBox21.Attributes.Add("Value", ds1.Tables[0].Rows[26]["ID"].ToString());
            Label43.Text = "Rs. " + ds1.Tables[0].Rows[26]["MEDICAL_TEST_CHARGE"].ToString();        
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#EEFFAA'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Label3.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();
        Label4.Text = ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        reset();

        Panel1.Visible = false;
        string patientName = TextBox1.Text;
        Common_SearchOPDPatientBL objSearchOPDPatientBL = new Common_SearchOPDPatientBL();
        ds = objSearchOPDPatientBL.Common_SearchOPDPatient(patientName);
        if (ds.Tables[0].Rows.Count == 0)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            Label1.Visible = true;
            Label1.Text = "No Patient Found";
            Label1.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            Label1.Visible = false;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }

    protected void reset()
    {
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;
        CheckBox4.Checked = false;
        CheckBox5.Checked = false;
        CheckBox6.Checked = false;
        CheckBox7.Checked = false;
        CheckBox8.Checked = false;
        CheckBox9.Checked = false;
        CheckBox10.Checked = false;
        CheckBox11.Checked = false;
        CheckBox12.Checked = false;
        CheckBox13.Checked = false;
        CheckBox14.Checked = false;
        CheckBox15.Checked = false;
        CheckBox16.Checked = false;
        CheckBox17.Checked = false;
        CheckBox18.Checked = false;
        CheckBox19.Checked = false;
        CheckBox20.Checked = false;
        CheckBox21.Checked = false;

        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
        RadioButton5.Checked = false;
        RadioButton6.Checked = false;

        TextBox2.Text = "";
        TextBox3.Text = "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        testDate = DateTime.ParseExact(TextBox2.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString();
        testTime = TextBox3.Text;
        int patientId = Convert.ToInt32(Label3.Text);
        int medicalTestId = -1;
        Common_AddOPDMedicalTestRegistrationBL objAddOPDMedicalTestRegistrationBL = new Common_AddOPDMedicalTestRegistrationBL();
        if (RadioButton1.Checked)
        {
            medicalTestList.Add(ds1.Tables[0].Rows[0]["MEDICAL_TEST"].ToString());
            medicalTestId = Convert.ToInt32(ds1.Tables[0].Rows[0]["ID"].ToString());
            opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
            testDate, testTime);
        }
        else if (RadioButton2.Checked)
        {
            medicalTestList.Add(ds1.Tables[0].Rows[1]["MEDICAL_TEST"].ToString());
            medicalTestId = Convert.ToInt32(ds1.Tables[0].Rows[1]["ID"].ToString());
            opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
            testDate, testTime);
        }
        else if (RadioButton3.Checked)
        {
            medicalTestList.Add(ds1.Tables[0].Rows[2]["MEDICAL_TEST"].ToString());
            medicalTestId = Convert.ToInt32(ds1.Tables[0].Rows[2]["ID"].ToString());
            opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
            testDate, testTime);
        }
        else if (RadioButton4.Checked)
        {
            medicalTestList.Add(ds1.Tables[0].Rows[3]["MEDICAL_TEST"].ToString());
            medicalTestId = Convert.ToInt32(ds1.Tables[0].Rows[3]["ID"].ToString());
            opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
            testDate, testTime);
        }
        else if (RadioButton5.Checked)
        {
            medicalTestList.Add(ds1.Tables[0].Rows[4]["MEDICAL_TEST"].ToString());
            medicalTestId = Convert.ToInt32(ds1.Tables[0].Rows[4]["ID"].ToString());
            opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
            testDate, testTime);
        }
        else if (RadioButton6.Checked)
        {
            medicalTestList.Add(ds1.Tables[0].Rows[5]["MEDICAL_TEST"].ToString());
            medicalTestId = Convert.ToInt32(ds1.Tables[0].Rows[5]["ID"].ToString());
            opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
            testDate, testTime);
        }
        
        List<CheckBox> checkBoxList = new List<CheckBox>();
        checkBoxList.Add(CheckBox1);
        checkBoxList.Add(CheckBox2);
        checkBoxList.Add(CheckBox3);
        checkBoxList.Add(CheckBox4);
        checkBoxList.Add(CheckBox5);
        checkBoxList.Add(CheckBox6);
        checkBoxList.Add(CheckBox7);
        checkBoxList.Add(CheckBox8);
        checkBoxList.Add(CheckBox9);
        checkBoxList.Add(CheckBox10);
        checkBoxList.Add(CheckBox11);
        checkBoxList.Add(CheckBox12);
        checkBoxList.Add(CheckBox13);
        checkBoxList.Add(CheckBox14);
        checkBoxList.Add(CheckBox15);
        checkBoxList.Add(CheckBox16);
        checkBoxList.Add(CheckBox17);
        checkBoxList.Add(CheckBox18);
        checkBoxList.Add(CheckBox19);
        checkBoxList.Add(CheckBox20);
        checkBoxList.Add(CheckBox21);

        foreach (CheckBox cb in checkBoxList)
        {
            if (cb.Checked)
            {
                medicalTestId = Convert.ToInt32(cb.Attributes["Value"]);
                GetMedicalTestByIdBL objGetMedicalTestByIdBL = new GetMedicalTestByIdBL();
                medicalTestList.Add(objGetMedicalTestByIdBL.GetMedicalTestById(medicalTestId));
                opdMedicalTestRegistrationId = objAddOPDMedicalTestRegistrationBL.Common_AddOPDMedicalTestRegistration(patientId, medicalTestId,
                    testDate, testTime);
            }
        }      
        
        Label1.Text = "OPD Medical Test Registered";
        Panel2.Visible = true;
        Label1.Visible = true;
        Label1.BackColor = System.Drawing.Color.Yellow;
        Panel1.Visible = false;
        TextBox2.Text = "";
        TextBox3.Text = "";
        GridView1.DataSource = null;
        GridView1.DataBind();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        reset();
        Panel2.Visible = false;
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox1.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[6]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[6]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox2.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[7]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[7]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox3.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[8]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[8]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox4.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[9]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[9]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox5.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[10]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[10]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox6.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[11]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[11]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox7.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[12]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[12]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox8.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[13]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[13]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    protected void CheckBox9_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes2();
        if (CheckBox9.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[14]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[14]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }

    private void uncheckRadioButtons()
    {
        if (RadioButton1.Checked || RadioButton2.Checked || RadioButton3.Checked || RadioButton4.Checked || RadioButton5.Checked || RadioButton6.Checked)
            Label2.Text = "0";
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
        RadioButton5.Checked = false;
        RadioButton6.Checked = false;
    }

    private void uncheckCheckBoxes1()
    {
        if (CheckBox1.Checked || CheckBox2.Checked || CheckBox3.Checked || CheckBox4.Checked || CheckBox5.Checked || CheckBox6.Checked || CheckBox7.Checked || CheckBox8.Checked || CheckBox9.Checked)
            Label2.Text = "0";
        CheckBox1.Checked = false;
        CheckBox2.Checked = false;
        CheckBox3.Checked = false;
        CheckBox4.Checked = false;
        CheckBox5.Checked = false;
        CheckBox6.Checked = false;
        CheckBox7.Checked = false;
        CheckBox8.Checked = false;
        CheckBox9.Checked = false;
    }

    private void uncheckCheckBoxes2()
    {
        if (CheckBox10.Checked || CheckBox11.Checked || CheckBox12.Checked || CheckBox13.Checked || CheckBox14.Checked || CheckBox15.Checked || CheckBox16.Checked || CheckBox17.Checked || CheckBox18.Checked || CheckBox19.Checked || CheckBox20.Checked || CheckBox21.Checked)
            Label2.Text = "0";
        CheckBox10.Checked = false;
        CheckBox11.Checked = false;
        CheckBox12.Checked = false;
        CheckBox13.Checked = false;
        CheckBox14.Checked = false;
        CheckBox15.Checked = false;
        CheckBox16.Checked = false;
        CheckBox17.Checked = false;
        CheckBox18.Checked = false;
        CheckBox19.Checked = false;
        CheckBox20.Checked = false;
        CheckBox21.Checked = false;
    }


    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        uncheckCheckBoxes1();
        uncheckCheckBoxes2();
        if (RadioButton1.Checked)
            Label2.Text = ds1.Tables[0].Rows[0]["MEDICAL_TEST_CHARGE"].ToString();
        else
            Label5.Text = "0";
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        uncheckCheckBoxes1();
        uncheckCheckBoxes2();
        if (RadioButton2.Checked)
            Label2.Text = ds1.Tables[0].Rows[1]["MEDICAL_TEST_CHARGE"].ToString();
        else
            Label5.Text = "0";
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        uncheckCheckBoxes1();
        uncheckCheckBoxes2();
        if (RadioButton3.Checked)
            Label2.Text = ds1.Tables[0].Rows[2]["MEDICAL_TEST_CHARGE"].ToString();
        else
            Label5.Text = "0";
    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        uncheckCheckBoxes1();
        uncheckCheckBoxes2();
        if (RadioButton4.Checked)
            Label2.Text = ds1.Tables[0].Rows[3]["MEDICAL_TEST_CHARGE"].ToString();
        else
            Label5.Text = "0";
    }
    protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
    {
        uncheckCheckBoxes1();
        uncheckCheckBoxes2();
        if (RadioButton5.Checked)
            Label2.Text = ds1.Tables[0].Rows[4]["MEDICAL_TEST_CHARGE"].ToString();
        else
            Label5.Text = "0";
    }
    protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
    {
        uncheckCheckBoxes1();
        uncheckCheckBoxes2();
        if (RadioButton6.Checked)
            Label2.Text = ds1.Tables[0].Rows[5]["MEDICAL_TEST_CHARGE"].ToString();
        else
            Label5.Text = "0";
    }
    protected void CheckBox10_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox10.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[15]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[15]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox11_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox11.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[16]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[16]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox12_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox12.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[17]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[17]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox13_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox13.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[18]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[18]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox14_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox14.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[19]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[19]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox15_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox15.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[20]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[20]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox16_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox16.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[21]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[21]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox17_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox17.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[22]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[22]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox18_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox18.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[23]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[23]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox19_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox19.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[24]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[24]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox20_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox20.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) +  Convert.ToInt32(ds1.Tables[0].Rows[25]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[25]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void CheckBox21_CheckedChanged(object sender, EventArgs e)
    {
        uncheckRadioButtons();
        uncheckCheckBoxes1();
        if (CheckBox21.Checked)
            Label2.Text = (Convert.ToInt32(Label2.Text) + Convert.ToInt32(ds1.Tables[0].Rows[26]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
        else
            Label2.Text = (Convert.ToInt32(Label2.Text) - Convert.ToInt32(ds1.Tables[0].Rows[26]["MEDICAL_TEST_CHARGE"].ToString())).ToString();
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        AddOPDMedicalRegistrationInvoiceBL objAddOPDMedicalRegistrationInvoiceBL = new AddOPDMedicalRegistrationInvoiceBL();
        string invoiceId = objAddOPDMedicalRegistrationInvoiceBL.AddOPDMedicalRegistrationInvoice(Convert.ToInt32(Session["receptionistId"].ToString()), opdMedicalTestRegistrationId);
        string patientName = ds.Tables[0].Rows[GridView1.SelectedIndex][1].ToString();
        string patientId = ds.Tables[0].Rows[GridView1.SelectedIndex][0].ToString();

        PrintOPDMedicalTestRegistrationInvoiceBL objPrintOPDMedicalTestRegistrationInvoiceBL = new PrintOPDMedicalTestRegistrationInvoiceBL();
        byte[] file = objPrintOPDMedicalTestRegistrationInvoiceBL.PrintOPDMedicalTestRegistrationInvoice(invoiceId, patientName, patientId, testDate, testTime, medicalTestList);
        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.AddHeader("Content-Disposition", "attachment; filename=OPDMedicalTestRegistrationInvoice.pdf");
        Response.ContentType = "application/pdf";
        Response.Buffer = true;
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.BinaryWrite(file);
        Response.End();
        Response.Close();
    }
}