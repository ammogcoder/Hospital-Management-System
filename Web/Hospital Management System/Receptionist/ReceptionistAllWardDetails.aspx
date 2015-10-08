<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistAllWardDetails.aspx.cs" Inherits="Receptionist_ReceptionistAllWardDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistAllWardDetailsStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="center1">
            <br />
            <center>
                <img src="../images/icon21.png" /><span class="heading">All Ward Details</span>
            </center>
            <br />
        </div>
        <br />
        <div>
            <div id="div1">
                <center>
                <br />
                <table class="table">
                    <tr>
                        <td>
                            <center>
                                <b>Select Ward:</b>
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <center>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="WARD_NAME" DataValueField="ID" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                <hr />
                            </center>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT [ID], [WARD_NAME] FROM [WARD_TABLE]"></asp:SqlDataSource>
                            <br />
                            <asp:MultiView ID="MultiView1" runat="server">
                                <asp:View ID="View1" runat="server">
                                    <center>
                                        <asp:Table ID="Table1" runat="server" CellSpacing="20">
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell101" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=101', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 101</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell102" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=102', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 102</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell103" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=103', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 103</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell104" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=104', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 104</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell105" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=105', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 105</a></b></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell106" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=106', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 106</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell107" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=107', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 107</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell108" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=108', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 108</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell109" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=109', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 109</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell110" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=1&wardNumber=110', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 110</a></b></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </center>
                                </asp:View>
                                <asp:View ID="View2" runat="server">
                                    <center>
                                        <asp:Table ID="Table2" runat="server" CellSpacing="20">
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell201" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=201', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 201</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell202" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=202', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 202</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell203" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=203', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 203</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell204" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=204', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 204</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell205" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=205', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 205</a></b></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell206" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=206', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 206</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell207" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=207', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 207</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell208" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=208', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 208</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell209" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=209', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 209</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell210" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=3&wardNumber=210', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 210</a></b></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </center>
                                </asp:View>
                                    <asp:View ID="View3" runat="server">
                                    <center>
                                        <asp:Table ID="Table3" runat="server" CellSpacing="20">
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell301" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=301', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 301</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell302" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=302', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 302</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell303" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=303', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 303</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell304" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=304', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 304</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell305" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=305', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 305</a></b></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell306" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=306', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 306</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell307" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=307', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 307</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell308" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=308', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 308</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell309" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=309', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 309</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell310" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=4&wardNumber=310', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 310</a></b></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </center>
                                </asp:View>
                                    <asp:View ID="View4" runat="server">
                                    <center>
                                        <asp:Table ID="Table4" runat="server" CellSpacing="20">
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell401" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=401', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 401</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell402" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=402', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 402</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell403" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=403', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 403</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell404" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=404', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 404</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell405" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=405', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 405</a></b></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell406" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=406', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 406</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell407" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=407', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 407</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell408" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=408', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 408</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell409" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=409', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 409</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell410" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=5&wardNumber=410', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 410</a></b></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </center>
                                </asp:View>
                                    <asp:View ID="View5" runat="server">
                                    <center>
                                        <asp:Table ID="Table5" runat="server" CellSpacing="20">
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell501" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=501', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 501</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell502" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=502', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 502</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell503" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=503', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 503</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell504" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=504', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 504</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell505" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=505', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 505</a></b></asp:TableCell>
                                            </asp:TableRow>
                                            <asp:TableRow runat="server">
                                                <asp:TableCell ID="TableCell506" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=506', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white" target="_blank">Room 506</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell507" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=507', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 507</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell508" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=508', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 508</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell509" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=509', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 509</a></b></asp:TableCell>
                                                <asp:TableCell ID="TableCell510" runat="server" BorderStyle="Ridge" BackColor="red" ForeColor="white"><b><a href="#" onclick="window.open('ReceptionistRoomDetails.aspx?wardId=6&wardNumber=510', 'Room Details', 'width=600, height=500');" style="text-decoration:none; color:white">Room 510</a></b></asp:TableCell>
                                            </asp:TableRow>
                                        </asp:Table>
                                    </center>
                                </asp:View>
                            </asp:MultiView>
                        </td>
                    </tr>
                </table>
            </center>
            </div>
        </div>
    </form>
</body>
</html>