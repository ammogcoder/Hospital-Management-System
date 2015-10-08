<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistViewCalendarAppointments.aspx.cs" Inherits="Receptionist_ReceptionistViewDoctorCalendarAppointments" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistViewCalendarAppointmentsStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <link rel="stylesheet" href="../css/jquery-ui.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistViewDoctorCalendarAppointmentsScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <div>
        <center>
            <div>
                <center>
                    <div id="center1">
                        <br />
                        <center>
                            <img src="../images/icon16.png" /><span class="heading">Doctor Appointments</span>
                        </center>
                        <br />
                    </div>
                    <br />
                    <table id="table1" style="display:none">
                        <tr>
                            <th colspan="2">
                                Filter Appointments By Doctor
                                <hr />
                            </th>
                        </tr>
                        <tr>
                        <td>
                            <b>Select Doctor:</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        </td>
                    </tr>
                    </table>
                    <br />
                    <fieldset id="fieldset1">
                        <legend id="legend1">Appointment Details</legend>
                        <table id="table2">
                        <tr>
                            <td colspan="2">
                                <center>
                                    <asp:LinkButton ID="LinkButton4" runat="server" BackColor="Pink" OnClick="LinkButton4_Click">Cancel Selected Appointment(s)</asp:LinkButton>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" RowStyle-HorizontalAlign="Center" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                    <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                                        <Columns>
                                            <asp:TemplateField HeaderText="Select">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="DOCTOR_NAME" HeaderText="Doctor Name" />
                                            <asp:BoundField DataField="APPOINTMENT_DATE" HeaderText="Date" ItemStyle-Width="10%" />
                                            <asp:BoundField DataField="APPOINTMENT_TOKEN" HeaderText="Token" ItemStyle-Width="15%" >
                                            <ItemStyle Width="10%"></ItemStyle>
                                            </asp:BoundField>
                                            <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" />
                                            <asp:BoundField DataField="APPOINTMENT_TIME" HeaderText="Time" ItemStyle-Width="8%" >
                                            <ItemStyle Width="8%"></ItemStyle>
                                            </asp:BoundField>
                                            <asp:CommandField HeaderText="Reschedule" ShowSelectButton="true" ItemStyle-Width="15%" />
                                        </Columns>

                                        <HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                                        <RowStyle HorizontalAlign="Center"></RowStyle>
                                    </asp:GridView>
                                </center>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:MultiView ID="MultiView1" runat="server">
                            <asp:View ID="View1" runat="server">
                                <div id="div1">
                                    <fieldset id="fieldset2">
                                        <legend id="legend2">Edit Appointment</legend>
                                        <asp:Panel ID="Panel1" runat="server" Visible="false">
                                            <br />
                                            <b><asp:Label ID="Label4" runat="server" Text="Appointment Edited" BackColor="Yellow" Font-Size="Large"></asp:Label></b>
                                            &nbsp;&nbsp;
                                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Print Invoice</asp:LinkButton>
                                            &nbsp;&nbsp;
                                            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Send SMS</asp:LinkButton>
                                            <br />
                                        </asp:Panel>
                                        <table>
                                            <tr class="tr1">
                                                <td class="td1">
                                                    <span class="span1"><b style="color:red">*</b>Appointment Token:</span>
                                                </td>
                                                <td class="td1">
                                                    <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <span class="span1"><b style="color:red">*</b>Appointment Date:</span>
                                                </td>
                                                <td>
                                                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                    <asp:TextBox ID="TextBox1" runat="server" Width="200"></asp:TextBox>
                                                    <br />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter appointment date" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <span class="span1"><b style="color:red">*</b>Appointment Time:</span>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox2" runat="server" Width="200"></asp:TextBox>
                                                    <br />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter appointment time" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <center>
                                                        <asp:Button ID="Button1" runat="server" Text="Reschedule Appointment" CssClass="button" OnClick="Button1_Click"></asp:Button>
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" OnClick="Button2_Click" CausesValidation="false"></asp:Button>
                                                    </center>
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </div>
                                <br />
                            </asp:View>
                        </asp:MultiView>
                    <b><asp:Label ID="Label2" runat="server" Text="Appointment(s) Canceled" BackColor="Yellow" Visible="false"></asp:Label></b>
                </fieldset>
        </center>
    </div>
    </form>
</body>
</html>
