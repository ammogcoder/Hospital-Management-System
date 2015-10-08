<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDObservationHistory.aspx.cs" Inherits="Doctor_DoctorIPDObservationHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorIPDObservationHistoryStyle.css"
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div>
                <div id="center1">
                    <br />
                    <center>
                        <img src="../images/icon16.png" /><span class="heading">IPD Observation History</span>
                    </center>
                    <br />
                </div>
                <br />
                <div id="div1">
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="460px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle">
                        <Columns>
                            <asp:BoundField DataField="ID" Visible="false"/>
                            <asp:BoundField DataField="OBSERVATION_DATE" HeaderText="Observation Date" ItemStyle-Width="150"/>
                            <asp:BoundField DataField="OBSERVATION_TIME" HeaderText="Observation Time" ItemStyle-Width="150" />
                            <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" ItemStyle-Width="100" />
                        </Columns>
                    </asp:GridView>
                    <br />
                </div>
            </div>
        </center>
    </form>
</body>
</html>
