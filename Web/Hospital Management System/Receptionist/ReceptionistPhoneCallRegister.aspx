<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistPhoneCallRegister.aspx.cs" Inherits="Receptionist_ReceptionistPhoneCallRegister" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistPhoneCallRegisterStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="center1">
                <br />
                <center>
                    <img src="../images/icon17.png" height="40" width="40" /><span class="heading">Call Register</span>
                </center>
                <br />
            </div>
            <br />
            <div id="div1">
                <center>
                    <div>
                        <br />
                        <fieldset id="fieldset1">
                            <legend id="legend1">Select Call Criteria</legend>
                            <table>
                                <tr>
                                    <td>
                                        <span class="span1"><b style="color:red">*</b>Call Type:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                                            <asp:ListItem Value="1">General Inquiry Calls</asp:ListItem>
                                            <asp:ListItem Value="2">Emergency Calls</asp:ListItem>
                                            <asp:ListItem Value="3">Forward Calls</asp:ListItem>
                                            <asp:ListItem Value="4">Message Calls</asp:ListItem>
                                            <asp:ListItem Value="5">Appointment Calls</asp:ListItem>
                                        </asp:DropDownList>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please select a call type" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <span class="span1"><asp:CheckBox ID="CheckBox1" runat="server" Enabled="true" Text="Filter By Date" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" /></span>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>                        
                        <asp:Panel runat="server" ID="Panel1" Visible="false">
                            <br />
                            <fieldset id="fieldset2">
                                <legend id="legend2">Select Call Filter</legend>
                                <table id="table3">
                                    <tr>
                                        <td>
                                            <span class="span1">From Date</span>
                                        </td>
                                        <td>
                                            <span class="span1">To Date</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                            <asp:TextBox ID="TextBox1" runat="server" Width="100"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox2" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                            <asp:TextBox ID="TextBox2" runat="server" Width="100"></asp:TextBox>
                                        </td>
                                        <td class="td1">
                                            <asp:Button ID="Button1" runat="server" Text="Filter" CssClass="button" OnClick="Button1_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                    </asp:Panel>
                </center>
                <br />
                <center>
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </center>
                <center>
                    <asp:MultiView ID="MultiView1" runat="server">
                        <asp:View ID="View1" runat="server">
                            <asp:GridView ID="GridView1" RowStyle-BackColor="OldLace" runat="server" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" Width="95%" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" OnRowDataBound="GridView1_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="Call Date" DataField="CALL_DATE" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Call Time" DataField="CALL_TIME" ItemStyle-Width="100"/>
                                    <asp:BoundField HeaderText="Caller Name" DataField="CALLER_NAME" />
                                    <asp:BoundField HeaderText="Caller Query" DataField="CALLER_QUERY" />
                                    <asp:BoundField HeaderText="Call Outcome" DataField="CALL_OUTCOME" />
                                </Columns>
                                <RowStyle HorizontalAlign="Center" />
                            </asp:GridView>
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                            <asp:GridView ID="GridView2" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" Width="95%" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" OnRowDataBound="GridView2_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="Call Date" DataField="CALL_DATE" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Call Time" DataField="CALL_TIME" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Caller Name" DataField="CALLER_NAME" />
                                    <asp:BoundField HeaderText="Caller Area" DataField="CALLER_AREA" />
                                    <asp:BoundField HeaderText="Emergency Details" DataField="EMERGENCY_DETAILS" />
                                </Columns>
                            </asp:GridView>
                        </asp:View>
                        <asp:View ID="View3" runat="server">
                            <asp:GridView ID="GridView3" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" Width="95%" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" OnRowDataBound="GridView3_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="Call Date" DataField="CALL_DATE" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Call Time" DataField="CALL_TIME" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Caller Name" DataField="CALLER_NAME" />
                                    <asp:BoundField HeaderText="Call Forwarded To" DataField="EMPLOYEE_NAME" />
                                </Columns>
                            </asp:GridView>
                        </asp:View>
                        <asp:View ID="View4" runat="server">
                            <asp:GridView ID="GridView4" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" Width="95%" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" OnRowDataBound="GridView4_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="Call Date" DataField="CALL_DATE" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Call Time" DataField="CALL_TIME" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Caller Name" DataField="CALLER_NAME" />
                                    <asp:BoundField HeaderText="Message For" DataField="EMPLOYEE_NAME" />
                                    <asp:BoundField HeaderText="Message Contents" DataField="MESSAGE_CONTENT" />
                                </Columns>
                            </asp:GridView>
                        </asp:View>
                        <asp:View ID="View5" runat="server">
                            <asp:GridView ID="GridView5" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat">
                                <Columns>
                                    <asp:BoundField HeaderText="Call Date" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Call Time" ItemStyle-Width="100" />
                                    <asp:BoundField HeaderText="Caller Name" />
                                </Columns>
                            </asp:GridView>
                        </asp:View>
                    </asp:MultiView>
                </center>
                <br />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>