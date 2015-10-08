<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistRoomDetails.aspx.cs" Inherits="Receptionist_ReceptionistWardDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistRoomDetailsStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="center1">
        <br />
        <center>
            <img src="../images/icon22.png" /><span class="heading">Room Details</span>
        </center>
        <br />
    </div>
        <br />
    <div>
        <asp:Panel ID="Panel1" runat="server" Visible="false" CssClass="panel1">
            <center>
                <br />
                <fieldset id="fieldset1">
                    <legend id="legend1">Patient General Information</legend>
                    <table>
                        <tr>
                            <td>
                                Patient Name:
                            </td>
                            <td>
                                <b><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Patient Gender:
                            </td>
                            <td>
                                <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Patient DOB:
                            </td>
                            <td>
                                <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Patient Address:
                            </td>
                            <td>
                                <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Patient Phone No:
                            </td>
                            <td>
                                <b><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Patient Email Address:
                            </td>
                            <td>
                                <b><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </center>
            <br />
            <br />
            <center>
                <fieldset id="fieldset2">
                    <legend id="legend2">Patient Medical Information</legend>
                    <table>
                        <tr>
                            <td>
                                Case Number:
                            </td>
                            <td>
                                <b><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Attending Doctor:
                            </td>
                            <td>
                                <b><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Date Of Admit: 
                            </td>
                            <td>
                                <b><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Time Of Admit:
                            </td>
                            <td>
                                <b><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Remark:
                            </td>
                            <td>
                                <b><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </center>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
