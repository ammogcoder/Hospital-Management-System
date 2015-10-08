using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HR_HRRegisterPersonnelReceptionist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        if (!IsPostBack)
        {
            DropDownList1.Items.Add(new ListItem("--Select--", "0"));
            DropDownList2.Items.Add(new ListItem("--Select--", "0"));
            DropDownList5.Items.Add(new ListItem("--Select--", "0"));
            DropDownList3.Items.Add(new ListItem("--Select--", "0"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int empNamePrefix = Convert.ToInt32(DropDownList3.SelectedValue);
        string empFirstName = TextBox1.Text;
        string empLastName = TextBox2.Text;
        int empGender = Convert.ToInt32(DropDownList1.SelectedIndex);
        string empDOB = TextBox3.Text;
        string empStreetAddress = TextBox4.Text;
        string empCity = TextBox5.Text;
        int empZipCode = Convert.ToInt32(TextBox11.Text);
        string empState = TextBox6.Text;
        string empCountry = DropDownList2.Text;
        string empPrimaryPhoneNumber = TextBox7.Text;
        string empSecondaryPhoneNumber = TextBox8.Text;
        string empEmailAddress = TextBox9.Text;
        string empPanId = TextBox10.Text;
        int empType = 2;
        string empDateOfJoin = TextBox18.Text;
        string empDateOfLeave = "";
        int empBank = Convert.ToInt32(DropDownList5.SelectedIndex);
        string empAccountNumber = TextBox19.Text;
        string empShiftStart = TextBox20.Text;
        string empShiftEnd = TextBox21.Text;

        RegisterEmployeeBL objRegisterEmployeeBL = new RegisterEmployeeBL();
        /*int receptionistEmpId = objRegisterEmployeeBL.RegisterEmployee(empNamePrefix, empFirstName, empLastName,
            empGender, empDOB, empStreetAddress, empCity, empZipCode, empState, empCountry,
            empPrimaryPhoneNumber, empSecondaryPhoneNumber, empEmailAddress, empPanId, empType,
            empDateOfJoin, empDateOfLeave, empBank, empAccountNumber, empShiftStart, empShiftEnd);*/

        string marks10 = TextBox10.Text;
        string marks12 = TextBox12.Text;

        RegisterEmployeeReceptionistBL objRegisterEmployeeReceptionistBL = new RegisterEmployeeReceptionistBL();
        //int receptionistId = objRegisterEmployeeReceptionistBL.RegisterEmployeeReceptionist(receptionistEmpId, marks10, marks12);

        //string receptionistUsername = "receptionist_" + receptionistEmpId;

        var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        var stringChars = new char[8];
        var random = new Random();
        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        var receptionistPassword = new String(stringChars);
        //Label1.Text="Receptionist account created successfuly. <br />Username is <b>" + receptionistUsername + "</b> and temporary Password is <b>" + receptionistPassword + "</b>";
        Label1.Visible = true;

        Common_LoginBL objLoginBL = new Common_LoginBL();
        //objLoginBL.Common_InsertTemporaryLogin(receptionistEmpId, receptionistUsername, receptionistPassword);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}