<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HRRegisterEmployeeReceptionist.aspx.cs" Inherits="HR_HRRegisterPersonnelReceptionist" MasterPageFile="~/HR/HRMasterPage.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">

    <link rel="stylesheet" href="../css/HR/HRRegisterEmployeeReceptionistStyle.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript">
        $(document).ready(function (e) {
            $("#<%=TextBox20.ClientID%>").timepicker();
            $("#<%=TextBox21.ClientID%>").timepicker();
        });
    </script>
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="style2" id="div5">
        <br />
        <center>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="false" BackColor="Yellow"></asp:Label>
        </center>
        <table id="table1">
             <tr>
                 <td>
                     <b>Name Prefix:</b>
                 </td>
                 <td>
                     <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="PREFIX" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [PREFIX_TABLE]"></asp:SqlDataSource>
                     <br />
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please select name prefix" ControlToValidate="DropDownList3" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                 </td>
                <td>
                    <b>First Name:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter first name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b class="b1">Last Name:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter last name" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>                
                <td>
                    <b>Gender:</b>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource4" DataTextField="GENDER" DataValueField="ID"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [GENDER_TABLE]"></asp:SqlDataSource>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please select gender" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b class="b1">Date Of Birth:</b>
                </td>
                <td>
                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox3"></asp:CalendarExtender>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter date of birth" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <b class="b1">Street Address:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter street address" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>City:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter city" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <b class="b1">Zip Code:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please enter zip code" ControlToValidate="TextBox11" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>State:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please enter state" ControlToValidate="TextBox6" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <b class="b1">Country:</b>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="COUNTRY_NAME" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [COUNTRY_TABLE]"></asp:SqlDataSource>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please select country" ControlToValidate="DropDownList2" Display="Dynamic" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Primary Phone Number:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please enter primary phone number" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <b class="b1">Secondary Phone Number:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>% Marks in 10th Standard:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td>
                    <b>% Marks in 12th Standard:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Email Address:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                  <td>
                    <b class="b1">Bank Where Account is Held :</b>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource5" DataTextField="BANK_NAME" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [BANK_NAME_TABLE]"></asp:SqlDataSource>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="Please select bank" ControlToValidate="DropDownList5" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Bank Account Number:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox19" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="Please enter bank account number" ControlToValidate="TextBox19" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <b class="b1">Date of Joining:</b>
                </td>
                <td>
                    <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox18"></asp:CalendarExtender>
                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="Please enter date of joining" ControlToValidate="TextBox18" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Shift Start Time:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ErrorMessage="Please enter shift start time" ControlToValidate="TextBox20" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <b class="b1">Shift End Time:</b>
                </td>
                <td>
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" ErrorMessage="Please enter shift end time" ControlToValidate="TextBox21" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <center>
            <div id="div6">
                <asp:Button ID="Button1" runat="server" Text="Register" CssClass="button" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Reset" CssClass="button" OnClick="Button2_Click" />
            </div>
        </center>
        <br />
        <br />
    </div>
</asp:Content>