<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDAllIPDObservationReports.aspx.cs" Inherits="Doctor_DoctorViewIPDAllIPDObservationReports" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewIPDAllIPDObservationReportsStyle.css"
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div>
                <center>
                    <img src="../images/icon26.png" /><span class="heading">IPD Observation Past Reports</span>
                </center>
                <br />
                <a href="#" onclick="window.close();">Close Window</a>
                <br />
                <br />
                <div id="div1">
                <br />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1160px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="ID" Visible="false"/>
                        <asp:BoundField DataField="IPD_ID_FK" Visible="false"/>
                        <asp:BoundField DataField="OBSERVATION_DATE" HeaderText="Observation Date" ItemStyle-Width="110"/>
                        <asp:BoundField DataField="OBSERVATION_TIME" HeaderText="Observation Time" ItemStyle-Width="110"/>
                        <asp:BoundField DataField="PROBLEM" HeaderText="Problem" />
                        <asp:BoundField DataField="PROBLEM_DETAILS" HeaderText="Problem Details" />
                        <asp:BoundField DataField="SYSTEM_REVIEW" HeaderText="System Review" />
                        <asp:BoundField DataField="ASSESSMENT" HeaderText="Assessment" />
                        <asp:BoundField DataField="FUTURE_PLAN" HeaderText="Plan" />
                        <asp:ButtonField HeaderText="View Medicines" Text="View" CommandName="Select" ItemStyle-Width="100" />
                    </Columns>
                </asp:GridView>
                <b><asp:Label ID="Label1" runat="server" Text="No Reports To Display" Visible="false" ForeColor="Red"></asp:Label></b>
                    <br />
                </div>
            </div>
        </center>
    </form>
</body>
</html>
