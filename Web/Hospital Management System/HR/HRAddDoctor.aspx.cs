using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HR_HRRegisterPersonnelDoctor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            DropDownList3.Items.Add(new ListItem("--Select--", "0"));
            DropDownList4.Items.Add(new ListItem("--Select--", "0"));
            DropDownList5.Items.Add(new ListItem("--Select--", "0"));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string empName = TextBox2.Text;
        string empGender = DropDownList1.SelectedValue;
        string empDOB = TextBox3.Text;
        string empAddress = TextBox4.Text;
        string empPhoneNumber = TextBox7.Text;
        string empEmailAddress = TextBox9.Text;
        int empType = 1;
        string empDateOfJoin = TextBox18.Text;
        string empDateOfLeave= "";
        int empBank = Convert.ToInt32(DropDownList5.SelectedIndex);
        string empAccountNumber = TextBox19.Text;

       /* RegisterEmployeeBL objRegisterEmployeeBL = new RegisterEmployeeBL();
        int doctorEmpId = objRegisterEmployeeBL.RegisterEmployee(empNamePrefix, empFirstName, empLastName,
            empGender, empDOB, empStreetAddress, empCity, empZipCode, empState, empCountry,
            empPrimaryPhoneNumber, empSecondaryPhoneNumber, empEmailAddress, empPanId, empType,
            empDateOfJoin, empDateOfLeave, empBank, empAccountNumber, empShiftStart, empShiftEnd);
        
        string doctorLicenseNumber = TextBox12.Text;
        int doctorDepartment = Convert.ToInt32(DropDownList3.SelectedIndex);
        int doctorDegree = Convert.ToInt32(DropDownList4.SelectedIndex);
        int doctorExperience = Convert.ToInt32(TextBox13.Text);

        RegisterEmployeeDoctorBL objRegisterEmployeeDoctorBL = new RegisterEmployeeDoctorBL();
        objRegisterEmployeeDoctorBL.RegisterEmployeeDoctor(doctorEmpId, doctorLicenseNumber,
        doctorDepartment, doctorDegree, doctorUniversityName, doctorUniversityCity,
        doctorUniversityState, doctorUniversityCountry, doctorExperience);*/
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string monSess1From = "1900-01-01";
        string monSess1To = "1900-01-01";
        string monSess2From = "1900-01-01";
        string monSess2To = "1900-01-01";
        string monSess3From = "1900-01-01";
        string monSess3To = "1900-01-01";
        string tueSess1From = "1900-01-01";
        string tueSess1To = "1900-01-01";
        string tueSess2From = "1900-01-01";
        string tueSess2To = "1900-01-01";
        string tueSess3From = "1900-01-01";
        string tueSess3To = "1900-01-01";
        string wedSess1From = "1900-01-01";
        string wedSess1To = "1900-01-01";
        string wedSess2From = "1900-01-01";
        string wedSess2To = "1900-01-01";
        string wedSess3From = "1900-01-01";
        string wedSess3To = "1900-01-01";
        string thuSess1From = "1900-01-01";
        string thuSess1To = "1900-01-01";
        string thuSess2From = "1900-01-01";
        string thuSess2To = "1900-01-01";
        string thuSess3From = "1900-01-01";
        string thuSess3To = "1900-01-01";
        string friSess1From = "1900-01-01";
        string friSess1To = "1900-01-01";
        string friSess2From = "1900-01-01";
        string friSess2To = "1900-01-01";
        string friSess3From = "1900-01-01";
        string friSess3To = "1900-01-01";
        string satSess1From = "1900-01-01";
        string satSess1To = "1900-01-01";
        string satSess2From = "1900-01-01";
        string satSess2To = "1900-01-01";
        string satSess3From = "1900-01-01";
        string satSess3To = "1900-01-01";
        string sunSess1From = "1900-01-01";
        string sunSess1To = "1900-01-01";
        string sunSess2From = "1900-01-01";
        string sunSess2To = "1900-01-01";
        string sunSess3From = "1900-01-01";
        string sunSess3To = "1900-01-01";

        if(TextBox20.Text != "")
            monSess1From = TextBox20.Text;
        if(TextBox21.Text != "")
            monSess1To = TextBox21.Text;
        if(TextBox22.Text != "")
            monSess2From = TextBox22.Text;
        if(TextBox23.Text != "")
            monSess2To = TextBox23.Text;
        if(TextBox24.Text != "")
            monSess3From = TextBox24.Text;
        if(TextBox25.Text != "")
            monSess3To = TextBox25.Text;
        if(TextBox26.Text != "")
            tueSess1From = TextBox26.Text;
        if(TextBox27.Text != "")
            tueSess1To = TextBox27.Text;
        if(TextBox28.Text != "")
            tueSess2From = TextBox28.Text;
        if(TextBox29.Text != "")
            tueSess2To = TextBox29.Text;
        if(TextBox30.Text != "")
            tueSess3From = TextBox30.Text;
        if(TextBox31.Text != "")
            tueSess3To = TextBox31.Text;
        if(TextBox32.Text != "")
            wedSess1From = TextBox32.Text;
        if(TextBox33.Text != "")
            wedSess1To = TextBox33.Text;
        if(TextBox34.Text != "")
            wedSess2From = TextBox34.Text;
        if(TextBox35.Text != "")
            wedSess2To = TextBox35.Text;
        if(TextBox36.Text != "")
            wedSess3From = TextBox36.Text;
        if(TextBox37.Text != "")
            wedSess3To = TextBox37.Text;
        if(TextBox38.Text != "")
            thuSess1From = TextBox38.Text;
        if(TextBox39.Text != "")
            thuSess1To = TextBox39.Text;
        if(TextBox40.Text != "")
            thuSess2From = TextBox40.Text;
        if(TextBox42.Text != "")
            friSess2To = TextBox42.Text;
            thuSess2To = TextBox42.Text;
        if(TextBox43.Text != "")
            thuSess3From = TextBox43.Text;
        if(TextBox44.Text != "")
            thuSess3To = TextBox44.Text;
        if(TextBox45.Text != "")
            friSess1From = TextBox45.Text;
        if(TextBox46.Text != "")
            friSess1To = TextBox46.Text;
        if(TextBox47.Text != "")
            friSess2From = TextBox47.Text;
        if(TextBox48.Text != "")
            friSess2To = TextBox48.Text;
        if(TextBox49.Text != "")
            friSess3From = TextBox49.Text;
        if(TextBox50.Text != "")
            friSess3To = TextBox50.Text;
        if(TextBox51.Text != "")
            satSess1From = TextBox51.Text;
        if(TextBox52.Text != "")
            satSess1To = TextBox52.Text;
        if(TextBox53.Text != "")
            satSess2From = TextBox53.Text;
        if(TextBox54.Text != "")
            satSess2To = TextBox54.Text;
        if(TextBox55.Text != "")
            satSess3From = TextBox55.Text;
        if(TextBox56.Text != "")
            satSess3To = TextBox56.Text;
        if(TextBox57.Text != "")
            sunSess1From = TextBox57.Text;
        if(TextBox58.Text != "")
            sunSess1To = TextBox58.Text;
        if(TextBox59.Text != "")
            sunSess2From = TextBox59.Text;
        if(TextBox60.Text != "")
            sunSess2To = TextBox60.Text;
        if(TextBox61.Text != "")
            sunSess3From = TextBox61.Text;
        if (TextBox62.Text != "")
            sunSess3To = TextBox62.Text;

    }
}