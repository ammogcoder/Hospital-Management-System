<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDActiveMedicines.aspx.cs" Inherits="Doctor_DoctorViewIPDActiveMedicines" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewIPDContinuingMedicinesStyle.css"
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <center>
                    <div>
                        <center>
                            <img src="../images/icon26.png" /><span class="heading">IPD Active Medicines</span>
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
                                    <asp:BoundField DataField="OBSERVATION_DATE" HeaderText="Observation Date"/>
                                    <asp:BoundField DataField="OBSERVATION_TIME" HeaderText="Observation Time" />
                                    <asp:BoundField DataField="PROBLEM" HeaderText="Problem" />
                                    <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" />
                                    <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                    <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Medicine Strength" />
                                    <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Medicine Quantity" />
                                    <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Medicine Start Date" />
                                    <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="Medicine Number Of Refills" />
                                    <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Medicine Instructions" />
                                    <asp:BoundField DataField="MEDICINE_STATUS" HeaderText="Medicine Status" />
                                    <asp:ButtonField HeaderText="Make Inactive" Text="Select" CommandName="Select" />
                                </Columns>
                            </asp:GridView>
                            <b><asp:Label ID="Label1" runat="server" Text="No Medicines To Display" Visible="false" ForeColor="Red"></asp:Label></b>
                            <br />
                        </div>
                    </div>
                </center>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
