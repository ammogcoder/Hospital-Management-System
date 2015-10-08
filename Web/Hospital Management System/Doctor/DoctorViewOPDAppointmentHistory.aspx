<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewOPDAppointmentHistory.aspx.cs" Inherits="Doctor_DoctorViewOPDAppointmentHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewOPDAppointmentHistoryStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <div>
                    <center>
                        <img src="../images/icon16.png" /><span class="heading">Appointment Details</span>
                        <br />
                        <a href="#" onclick="window.close();">Close Window</a>
                        <br />
                        <br />
                        <table id="table1" border="1">
                            <tr class="tr1">
                                <td>
                                    Appointment Token:
                                </td>
                                <td>
                                    <b><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></b>
                                </td>
                            </tr>
                            <tr class="tr2">
                                <td>
                                    Appointment Date:
                                </td>
                                <td>
                                    <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                                </td>
                            </tr>
                            <tr class="tr1">
                                <td>
                                    Appointment Time:
                                </td>
                                <td>
                                    <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <fieldset>
                            <legend>Prescription Details</legend>
                            <b><asp:Label ID="Label4" runat="server" Text="No Prescription Given" BackColor="Yellow" Visible="false"></asp:Label></b>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="900px" OnRowDataBound="GridView1_RowDataBound" AllowPaging="True" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging">
                                <Columns>
                                    <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                    <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" />
                                    <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                    <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Strength" />
                                    <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Quantity" />
                                    <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Start Date" />
                                    <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="# Refills" />
                                    <asp:BoundField DataField="MEDICINE_QUANTITY_ON_REFILLS" HeaderText="Quantity on Refills" />
                                    <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Instructions" />
                                </Columns>
                                <PagerSettings Mode="NumericFirstLast" />
                                <PagerStyle BackColor="#99FF99" HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:GridView>
                        </fieldset>
                    </center>
                </div>
            </center>
        </div>
    </form>
</body>
</html>
