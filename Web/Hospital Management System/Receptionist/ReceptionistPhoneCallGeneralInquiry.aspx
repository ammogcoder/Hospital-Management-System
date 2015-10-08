<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistPhoneCallGeneralInquiry.aspx.cs" Inherits="Receptionist_ReceptionistPhoneCallGeneralInquiry" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistPhoneCallGeneralInquiryStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistPhoneCallGeneralInquiryScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <div>
        <div id="center1">
            <br />
            <center>
                <img src="../images/icon9.png" /><span class="heading">General Inquiry Phone Call</span>
            </center>
            <br />
        </div>
        <center>
            <br />
            <div id="div1">
                <div>
                    <br />
                    <table>
                        <tr>
                            <td colspan="2">
                                <center>
                                    <b><asp:Label ID="Label5" runat="server" Text="" BackColor="Yellow"></asp:Label></b>
                                    <br />
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                <span class="span1"><b style="color:red">*</b>Phone No.:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Please enter phone no. in correct format" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter phone no." ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                <span class="span1"><b style="color:red">*</b>Call Date:</span>
                            </td>
                            <td>
                                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter calle date" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                <span class="span1"><b style="color:red">*</b>Call Time:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter call time" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                <span class="span1"><b style="color:red">*</b>Caller Name:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter name in correct format" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter caller name" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                <span class="span1"><b style="color:red">*</b>Caller Query:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter caller query" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                <span class="span1"><b style="color:red">*</b>Call Outcome:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter call outcome" ControlToValidate="TextBox6" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <br />
                                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="Reset" CssClass="button" CausesValidation="False" OnClick="Button2_Click" />
                            </td>
                        </tr>
                    </table>
                </div>      
                </div>    
            </center>
    </div>
    </form>
</body>
</html>
