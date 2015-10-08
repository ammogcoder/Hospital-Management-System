<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddReminder.aspx.cs" Inherits="Receptionist_ReceptionistAddReminder" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistAddReminderStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <div>
        <center>
            <div>
                <div id="center1">
                    <br />
                    <center>
                        <img src="../images/icon25.png" /><span class="heading">Add Reminder</span>
                    </center>
                </div>
                <br />
                <div id="div1">
                    <br />
                    <center>
                        <b><asp:Label ID="Label1" runat="server" Text="Reminder Added" Visible="false" BackColor="Yellow"></asp:Label></b>
                    </center>
                    <br />
                    <table>
                        <tr>
                            <td>
                                <span class="span1"><b style="color:red">*</b>Reminder Date:</span>
                            </td>
                            <td>
                                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter reminder date" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="p"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="span1"><b style="color:red">*</b>Reminder Title:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter reminder title" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="span1"><b style="color:red">*</b>Reminder Details:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter reminder details" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <center>
                                    <asp:Button ID="Button1" runat="server" Text="Add Reminder" CssClass="button" OnClick="Button1_Click"></asp:Button>
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Button ID="Button3" runat="server" Text="Reset" CssClass="button" CausesValidation="false" OnClick="Button3_Click"></asp:Button>
                                </center>
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
