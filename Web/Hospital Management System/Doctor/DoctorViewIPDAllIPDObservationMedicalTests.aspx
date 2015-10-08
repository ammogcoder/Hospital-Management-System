<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDAllIPDObservationMedicalTests.aspx.cs" Inherits="Doctor_DoctorViewIPDAllIPDObservationMedicalTests" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewIPDAllIPDObservationMedicalTestsStyle.css"
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <center>
                    <div>
                        <fieldset>
                            <legend>IPD All Medical Tests</legend>
                            <a href="#" onclick="window.close();">Close Window</a>
                            <br />
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1160px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="ID" Visible="false"/>
                                    <asp:BoundField DataField="OBSERVATION_DATE" HeaderText="Observation Date"/>
                                    <asp:BoundField DataField="OBSERVATION_TIME" HeaderText="Observation Time" />
                                    <asp:BoundField DataField="PROBLEM" HeaderText="Problem" />
                                    <asp:BoundField DataField="MEDICAL_TEST" HeaderText="Medical Test" />
                                    <asp:BoundField DataField="MEDICAL_TEST_DATE" HeaderText="Test Date" />
                                    <asp:BoundField DataField="MEDICAL_TEST_TIME" HeaderText="Test Time" />
                                    <asp:BoundField DataField="REMARKS" HeaderText="Remarks" />
                                    <asp:ButtonField HeaderText="View Details" Text="View" CommandName="Select" />
                                </Columns>
                            </asp:GridView>
                            <b><asp:Label ID="Label1" runat="server" Text="No Medical Tests To Display" Visible="false" ForeColor="Red"></asp:Label></b>
                        </fieldset>
                    </div>
                </center>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
