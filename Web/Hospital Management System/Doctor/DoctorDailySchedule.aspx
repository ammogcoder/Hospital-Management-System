<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorDailySchedule.aspx.cs" Inherits="Doctor_DoctorDailySchedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistViewDoctorScheduleStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="center1">
            <br />
            <center>
                <img src="../images/icon8.png" /><span class="heading">My Daily Schedule</span>
            </center>
            <br />
        </div>
        <br />
        <div id="div1">
            <center>
                <br />
                <asp:Label ID="Label43" runat="server" Text="" BackColor="Yellow"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" Visible="false" ForeColor="Red" OnClick="LinkButton1_Click">Cancel Leave</asp:LinkButton>
            </center>
            <table id="table1" border="1">
                <tr class="tr1">
                    <td>
                        Day
                    </td>
                    <td>
                        Session 1<br />From
                    </td>
                    <td>
                        Session 1<br />To
                    </td>
                    <td>
                        Session 2<br />From
                    </td>
                    <td>
                        Session 2<br />To
                    </td>
                    <td>
                        <b>
                            Session 3<br />From
                        </b>
                    </td>
                    <td>
                        Session 3<br />To
                    </td>
                </tr>
                <tr>
                    <td class="td1">MONDAY</td>
                    <td class="td2">
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td1">TUESDAY</td>
                    <td class="td2">
                            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td1">WEDNESDAY</td>
                    <td class="td2">
                            <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label17" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td1">THURSDAY</td>
                    <td class="td2">
                            <asp:Label ID="Label19" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label21" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label23" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td1">FRIDA</td>
                    <td class="td2">
                            <asp:Label ID="Label25" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label26" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                           <asp:Label ID="Label27" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label28" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label29" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label30" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td1">SATURDAY</td>
                    <td class="td2">
                            <asp:Label ID="Label31" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label32" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label33" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label34" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label35" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label36" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td1">SUNDAY</td>
                    <td class="td2">
                            <asp:Label ID="Label37" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label38" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label39" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label40" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label41" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="td2">
                            <asp:Label ID="Label42" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <center>
                <asp:Panel ID="Panel1" runat="server" Width="95%">
                    <div id="center2">
                        <br />
                        <center>
                            <span class="heading">Upcoming Doctor Appointments</span>
                        </center>
                        <br />
                    </div>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="95%" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" RowStyle-HorizontalAlign="Center" OnRowDataBound="GridView1_RowDataBound" RowStyle-BackColor="OldLace">
                        <Columns>
                            <asp:BoundField HeaderText="Appointment Token" DataField="APPOINTMENT_TOKEN" />
                            <asp:BoundField HeaderText="Patient Name" DataField="PATIENT_NAME" />
                            <asp:BoundField HeaderText="Appointment Date" DataField="APPOINTMENT_DATE" />
                            <asp:BoundField HeaderText="Appointment Time" DataField="APPOINTMENT_TIME" />
                        </Columns>
                    </asp:GridView>
                    <br />
                </asp:Panel>
            </center>
        </div>
    </div>
    </form>
</body>
</html>
