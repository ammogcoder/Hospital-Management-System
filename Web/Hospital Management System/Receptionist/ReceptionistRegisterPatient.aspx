<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistRegisterPatient.aspx.cs" Inherits="Receptionist_ReceptionistRegisterPatient"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title> 
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistRegisterPatientStyle.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistRegisterPatientScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <div id="div5">
            <div id="center1">
                <center>
                    <br />
                    <img src="../images/icon2.png" /><span class="heading">Register New Patient</span>
                    <br />
                </center>
                <br />
                </div>
            <br />
            <center>
                <b><asp:Label ID="Label3" runat="server" Visible="false" Text="Label" BackColor="Yellow" Font-Size="Large"></asp:Label></b>
            </center>
            <br />
            <br />
            <div id="div1">
                <br />
                <div>
                    <center>
                        <fieldset>
                        <legend>General Information</legend>
                        <center>
                            <table class="table1">
                                <tr>
                                    <td class="td1">
                                        <span class="span1"><b style="color:red">*</b>First Name:</span>
                                    </td>
                                    <td class="td2">
                                        <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ValidationGroup="p" ErrorMessage="Please enter first name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter first name in correct format" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="p"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="td1">
                                        <span class="span1">Middle Name:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter middle name in correct format" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="p"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="span1">Last Name:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please enter last name in correct format" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="p"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                        <span class="span1"><b style="color:red">*</b>Date Of Birth:</span>
                                    </td>
                                    <td>
                                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox4" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                        <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ValidationGroup="p" ErrorMessage="Please enter date of birth" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="p"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="span1"><b style="color:red">*</b>Gender:</span>
                                    </td>
                                    <td>
                                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                            <asp:ListItem Value="M">Male</asp:ListItem>
                                            <asp:ListItem Value="F">Female</asp:ListItem>
                                        </asp:RadioButtonList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="p" ErrorMessage="Please select gender" ControlToValidate="RadioButtonList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <span class="span1">Marital Status:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="select">
                                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                                            <asp:ListItem Value="S">Single</asp:ListItem>
                                            <asp:ListItem Value="M">Married</asp:ListItem>
                                            <asp:ListItem Value="D">Divorced</asp:ListItem>
                                            <asp:ListItem Value="W">Widowed</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="span1">Father Name:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Please enter father name in correct format" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="p"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                            </table>
                        </center>
                    </fieldset>
                    </center>
                </div>
                <br />
                <div>
                    <center>
                        <fieldset>
                        <legend>Contact Information</legend>
                        <center>
                            <table class="table1">
                                <tr>
                                    <td class="td1">
                                        <span class="span1"><b style="color:red">*</b>Primary Address:</span>
                                    </td>
                                    <td class="td2">
                                        <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ValidationGroup="p" ErrorMessage="Please enter primary address" ControlToValidate="TextBox6" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </td>
                                    <td class="td1">
                                        <span class="span1"><b style="color:red">*</b>Primary Phone No:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox8" runat="server" Width="200"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ValidationGroup="p" ErrorMessage="Please enter primary phone no." ControlToValidate="TextBox8" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="span1">Secondary Address:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox7" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                    </td>                                
                                    <td>
                                        <span class="span1">Secondary Phone No:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox9" runat="server" Width="200"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="span1">Email Address:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox10" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ErrorMessage="Please enter email in correct format" ControlToValidate="TextBox10" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                    </td>
                                    <td class="td1">
                                        <span class="span1">Emergency Contact<br />Name:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox11" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Please enter emergency contact name in correct format" ControlToValidate="TextBox11" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="p"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="span1">Emergency Contact<br />Number:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox12" runat="server" Width="200"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </center>
                    </fieldset>    
                    </center>     
                </div>
                <br />
                <div>
                    <center>
                        <fieldset>
                        <legend>Occupation Information</legend>
                        <table class="table1">
                            <tr>
                                <td class="td1">
                                    <span class="span1">Occupation Type:</span>
                                </td>
                                <td class="td2">
                                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="select">
                                        <asp:ListItem Value="0">--Select--</asp:ListItem>
                                        <asp:ListItem Value="1">Service</asp:ListItem>
                                        <asp:ListItem Value="2">Business</asp:ListItem>
                                        <asp:ListItem Value="3">Student</asp:ListItem>
                                        <asp:ListItem Value="4">Other</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="td1">
                                    <span class="span1">Occupation Name:</span>
                                </td>
                                <td class="td2">
                                    <asp:TextBox ID="TextBox18" runat="server" Width="200px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="span1">Occupation Address:</span>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox13" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                </td>
                                <td>
                                    <span class="span1">Monthly Income:</span>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox14" runat="server" Width="100"></asp:TextBox>
                                    <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ErrorMessage="Please enter monthly income in correct format" ControlToValidate="TextBox14" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                    </center>
                </div>
                <br />
                <div>
                    <center>
                        <fieldset>
                        <legend>Misc. Information</legend>
                        <table class="table1">
                            <tr>
                                <asp:Panel ID="Panel3" runat="server">
                                    <td class="td1">
                                        <span class="span1">Reference Source:</span>
                                    </td>
                                    <td class="td2">
                                        <asp:DropDownList ID="DropDownList3" CssClass="select" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource1" DataTextField="REFERENCE_SOURCE" DataValueField="ID" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [REFERENCE_SOURCE_TABLE]"></asp:SqlDataSource>
                                    </td>
                                </asp:Panel>
                                <asp:Panel ID="Panel2" runat="server" Visible="false">
                                    <td>
                                        <span class="span1">Reference:</span>
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Change</asp:LinkButton>
                                    </td>
                                </asp:Panel>
                                <td class="td1">
                                    <span class="span1">Primary Language:</span>
                                </td>
                                <td class="td2">
                                    <asp:TextBox ID="TextBox15" runat="server" Width="200px"></asp:TextBox>
                                    <br />
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ErrorMessage="Please enter primary language in correct format" ControlToValidate="TextBox15" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="p"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="span1">Family Size:</span>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox16" runat="server" Width="100"></asp:TextBox>
                                    <br />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ErrorMessage="Please enter family size in correct format" ControlToValidate="TextBox16" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                    </center>
                </div>
                <br />
                <br />
                <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="Label1" BackgroundCssClass="modalBackground" CancelControlID="Button5"></asp:ModalPopupExtender>
                <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" ScrollBars="Auto">
                    <center>
                        <fieldset id="fieldset1">
                            <legend id="legend1">Search Patient</legend>
                            <table>
                                <tr>
                                    <td>
                                        <span class="span1"><b style="color:red">*</b>Enter Patient Name:</span>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox17" runat="server" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter patient name" Display="Dynamic" ControlToValidate="TextBox17" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please enter patient name in correct format" ControlToValidate="TextBox17" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$"></asp:RegularExpressionValidator>
                                    </td>
                                </tr> 
                                <tr>
                                    <td colspan="2">
                                        <center>
                                            <br />
                                            <asp:Button ID="Button3" runat="server" Text="Search Patient" OnClick="Button3_Click" CssClass="button"></asp:Button>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="Button5" runat="server" Text="Close Window" CausesValidation="false" CssClass="button"></asp:Button>
                                        </center>
                                    </td>
                                </tr>
                            </table>  
                        </fieldset>
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" RowStyle-HorizontalAlign="Center" Width="500" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" RowStyle-BackColor="OldLace">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" />
                                <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" />
                                <asp:BoundField DataField="PATIENT_PRIMARY_PHONE" HeaderText="Phone No." />
                                    <asp:ButtonField Text="Select" CommandName="Select" />
                            </Columns>

                        </asp:GridView>
                    </center>
                </asp:Panel>
                <div>
                    <center>
                        <asp:Button ID="Button1" ValidationGroup="p" runat="server" Text="Register" CssClass="button" OnClick="Button1_Click"></asp:Button>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Reset" CssClass="button"></asp:Button>
                    </center>
                </div>
                <br />
                <br />    
            </div>
        </div>
    </form>
</body>
</html>
