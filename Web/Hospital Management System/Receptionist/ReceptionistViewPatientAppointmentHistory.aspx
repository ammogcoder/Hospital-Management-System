<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistViewPatientAppointmentHistory.aspx.cs" Inherits="Receptionist_ReceptionistViewPatientAppointmentHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistViewPatientAppointmentHistoryStyle.css"
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div>
                <fieldset>
                    <legend>Patient Appointment History</legend>
                    <a href="#" onclick="window.close();">Close Window</a>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="660px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="APPOINTMENT_TOKEN" HeaderText="Appointment Token" Visible="False" />
                            <asp:BoundField DataField="DOCTOR_NAME" HeaderText="Doctor Name" />
                            <asp:BoundField DataField="APPOINTMENT_DATE" HeaderText="Appointment Date" ItemStyle-Width="150" />
                            <asp:BoundField DataField="APPOINTMENT_TIME" HeaderText="Appointment Time" ItemStyle-Width="100" />
                            <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" />
                        </Columns>
                    </asp:GridView>
                </fieldset>
            </div>
        </center>
    </form>
</body>
</html>
