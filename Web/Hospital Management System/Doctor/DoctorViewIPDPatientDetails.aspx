<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDPatientDetails.aspx.cs" Inherits="Doctor_DoctorViewIPDPatientDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewIPDPatientDetailsStyle.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/Doctor/DoctorViewIPDPatientDetailsScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="center1">
            <br />
            <center>
                <img src="../images/icon2.png" /><span class="heading">IPD Patient Details</span>
            </center>
            <br />
        </div>
        <br />
        <div id="div1">
            <center>
                <br />
                <fieldset id="fieldset1">
                    <legend id="legend1">Medical Details</legend>
                    <table id="table1" class="table">
                        <tr>
                            <td class="td1">
                                Patient General Health:
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr7">
                            <td class="td1">
                                Regular Medications: 
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Allergy Status:
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr1">
                            <td class="td1">
                                Allergies:
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Major Surgery Status:
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr2">
                            <td class="td1">
                                Surgery 1:
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                <asp:Label ID="Label9" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr3">
                            <td class="td1">
                                Surgery 2:
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                <asp:Label ID="Label11" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr4">
                            <td class="td1">
                                Surgery 3:
                            </td>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                <asp:Label ID="Label13" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Medical Insurance Status:
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr5">
                            <td class="td1">
                                Insurance Provider:
                            </td>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr id="tr6">
                            <td class="td1">
                                Policy Number:</td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Patient Height (ft.):
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Patient Weight (kg):
                            </td>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Blood Group:
                            </td>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Date Of Admit:
                            </td>
                            <td>
                                <asp:Label ID="Label19" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Time Of Admit:
                            </td>
                            <td>
                                <asp:Label ID="Label20" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                First Observation:
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                <asp:Label ID="Label22" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="td1">
                                Last Observation:
                            </td>
                            <td>
                                <asp:Label ID="Label21" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                <asp:Label ID="Label23" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                                <br />
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Perform Observation</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </fieldset>
                <br />
            </center>
        </div>
    </div>
    </form>
</body>
</html>
