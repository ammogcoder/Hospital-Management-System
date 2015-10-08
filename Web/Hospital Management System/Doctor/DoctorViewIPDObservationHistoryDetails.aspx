<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDObservationHistoryDetails.aspx.cs" Inherits="Doctor_DoctorViewIPDObservationHistoryDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewIPDObservationHistoryDetailsStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <div>
                <div id="center1">
                    <br />
                    <center>
                        <img src="../images/icon18.png" /><span class="heading">IPD Observation Details</span>
                    </center>
                    <br />
                </div>
                <br />
                <div id="div1">
                    <br />
                    <table id="table1" border="1">
                        <tr class="tr1">
                            <td>
                                Patient Name:
                            </td>
                            <td class="td1">
                                <b><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Observation Date:
                            </td>
                            <td class="td1">
                                <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr class="tr1">
                            <td>
                                Observation Time:
                            </td>
                            <td class="td1">
                                <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Patient Health Condition:
                            </td>
                            <td class="td1">
                                <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    <fieldset id="fieldset1">
                        <legend id="legend2">Observation Report</legend>
                        <asp:GridView ID="GridView1" runat="server" RowStyle-BackColor="OldLace" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1000px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="Sr. No." ItemStyle-Width="50"/>
                                <asp:BoundField DataField="PROBLEM" HeaderText="Problem" ItemStyle-Width="150"/>
                                <asp:BoundField DataField="PROBLEM" HeaderText="Problem" ItemStyle-Width="150"/>
                                <asp:BoundField DataField="PROBLEM_DETAILS" HeaderText="Problem Details" ItemStyle-Width="150" />
                                <asp:BoundField DataField="SYSTEM_REVIEW" HeaderText="System Review" ItemStyle-Width="150" />
                                <asp:BoundField DataField="ASSESSMENT" HeaderText="Assessment" ItemStyle-Width="150" />
                                <asp:BoundField DataField="FUTURE_PLAN" HeaderText="Plan" ItemStyle-Width="150" />
                            </Columns>
                        </asp:GridView>
                    </fieldset>
                    <br />
                    <br />
                    <fieldset id="fieldset2">
                        <legend id="legend3">Medicine Details</legend>
                        <asp:GridView ID="GridView2" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1000px" OnRowDataBound="GridView2_RowDataBound" OnPageIndexChanging="GridView2_PageIndexChanging">
                            <Columns>
                                <asp:BoundField DataField="ID" Visible="false"/>
                                <asp:TemplateField HeaderText="Sr. No" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                <asp:BoundField DataField="IPD_OBSERVATION_REPORT_ID_FK" HeaderText="Observation No." />
                                <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" />
                                <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Strength" />
                                <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Quantity" />
                                <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Start Date" />
                                <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="# Refills" />
                                <asp:BoundField DataField="MEDICINE_QUANTITY_ON_REFILLS" HeaderText="Quantity on Refills" />
                                <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Instructions" />
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="Label5" runat="server" Text="No Medicine Prescribed" Visible="false" BackColor="Yellow" Font-Bold="true" Width="1000px"></asp:Label>
                    </fieldset>
                    <br />
                    <br />
                    <fieldset id="fieldset3">
                        <legend id="legend4">Medical Test Details</legend>
                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1000px" OnRowDataBound="GridView3_RowDataBound" OnPageIndexChanging="GridView3_PageIndexChanging">
                            <Columns>
                                <asp:BoundField DataField="ID" Visible="false"/>
                                <asp:TemplateField HeaderText="Sr. No" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                <asp:BoundField DataField="IPD_OBSERVATION_REPORT_ID_FK" HeaderText="Observation No." />
                                <asp:BoundField DataField="MEDICAL_TEST" HeaderText="Medicine Test" />
                                <asp:BoundField DataField="MEDICAL_TEST_DATE" HeaderText="Medical Test Date" />
                                <asp:BoundField DataField="MEDICAL_TEST_TIME" HeaderText="Medical Test Time" />
                                <asp:BoundField DataField="REMARKS" HeaderText="Remarks" />
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="Label6" runat="server" Text="No Medical Test Prescribed" Visible="false" BackColor="Yellow" Font-Bold="true" Width="98%"></asp:Label>
                    </fieldset>
                    <br />
                </div>
            </div>
        </center>
    </div>
    </form>
</body>
</html>
