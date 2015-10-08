<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorLeaveApplication.aspx.cs" Inherits="Doctor_DoctorLeaveApplication" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorLeaveApplicationStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Doctor/DoctorLeaveApplicationScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <div id="center1">
                        <br />
                        <center>
                            <img src="../images/icon17.png" /><span class="heading">Leave Application</span>
                        </center>
                        <br />
                    </div>
                    <br />
                    <center>
                        <div id="div1">
                            <br />
                            <fieldset id="fieldset1">
                                <legend id="legend1">Leave Application Details</legend>
                                <br />
                                <table>
                                    <tr>
                                        <td colspan="2">
                                            <center>
                                                <b><asp:Label ID="Label6" runat="server"></asp:Label></b>
                                                <br />
                                            </center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Leave From Date:</span>
                                        </td>
                                        <td>
                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                            <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                            <br />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter leave from date" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Leave From Time:</span>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                                            <br />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter leave from time" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Leave To Date:</span>
                                        </td>
                                        <td>
                                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox6" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                            <asp:TextBox ID="TextBox6" runat="server" Width="200px"></asp:TextBox>
                                            <br />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox6" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter leave to date" ControlToValidate="TextBox6" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Leave To Time:</span>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox7" runat="server" Width="200px"></asp:TextBox>
                                            <br />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please enter leave to time" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1">Leave Reason:</span>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click" />
                                            &nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="Button2" runat="server" Text="Reset" CssClass="button" CausesValidation="False" OnClick="Button2_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                            <br />
                        </div>
                    </center>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
