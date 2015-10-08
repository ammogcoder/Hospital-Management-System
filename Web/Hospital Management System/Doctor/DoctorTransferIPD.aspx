<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorTransferIPD.aspx.cs" Inherits="Doctor_DoctorTransferIPD" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorTransferIPDStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Doctor/DoctorTransferIPDScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox3" Format="dd/MM/yyyy"></asp:CalendarExtender>
                <div>
                    <div id="center1">
                        <br />
                        <center>
                            <img src="../images/icon24.png" /><span class="heading">Transfer IPD To Doctor</span>
                        </center>
                        <br />
                    </div>
                    <div id="div1">
                        <center>
                            <div>
                                <asp:Panel ID="Panel1" runat="server" Width="90%" CssClass="panel1">
                                    <br />
                                    <asp:Label ID="Label1" runat="server" Text="IPD Transferred To Doctor" BackColor="Yellow" Font-Bold="true" Visible="false"></asp:Label>
                                    <fieldset id="fieldset1">
                                        <legend id="legend1">Doctor Transfer Details</legend>
                                        <div>
                                            <table id="table2">
                                                <tr>
                                                    <td class="td1">
                                                        <b style="color:red">*</b><span class="span1">Transfer Date:</span>
                                                    </td>
                                                    <td class="td1">
                                                        <asp:TextBox ID="TextBox3" runat="server" Width="200"></asp:TextBox>
                                                        <br />
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter transfer date" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <b style="color:red">*</b><span class="span1">Transfer Time:</span>
                                                    </td>
                                                    <td class="td1">
                                                        <asp:TextBox ID="TextBox4" runat="server" Width="200"></asp:TextBox>
                                                        <br />
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter transfer time" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">&nbsp;&nbsp;&nbsp;&nbsp; 
                                                        <b style="color:red">*</b><span class="span1">Reason For Transfer:</span>
                                                    </td>
                                                    <td class="td1">
                                                        <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="200"></asp:TextBox>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter reason for transfer" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <b style="color:red">*</b><span class="span1">Select Doctor Department:</span>
                                                    </td>
                                                    <td class="td1">
                                                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="SPECIALITY" DataValueField="ID" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200"></asp:DropDownList>
                                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [DEPARTMENT_TABLE]"></asp:SqlDataSource>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please select new ward" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <b style="color:red">*</b><span class="span1">Select Doctor Name:</span>
                                                    </td>
                                                    <td class="td1">
                                                        <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" Width="200"></asp:DropDownList>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please select new ward number" ControlToValidate="DropDownList2" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2">
                                                        <br />
                                                        <center>
                                                            <asp:Button ID="Button2" runat="server" Text="Transfer To Doctor" CssClass="button" OnClick="Button2_Click" ValidationGroup="ValidationGroup2"></asp:Button>
                                                            &nbsp;&nbsp;&nbsp;
                                                            <asp:Button ID="Button3" runat="server" Text="Reset" CssClass="button" OnClick="Button3_Click" CausesValidation="False"></asp:Button>
                                                        </center>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                    </fieldset>
                                    <br />
                                </asp:Panel>    
                            </div>
                        </center>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="Button2" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
