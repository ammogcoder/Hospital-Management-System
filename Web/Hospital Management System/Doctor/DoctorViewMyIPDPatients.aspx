<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewMyIPDPatients.aspx.cs" Inherits="Doctor_DoctorViewMyIPDPatients" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewMyIPDPatientsStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <center>
                    <div>
                        <div id="center1">
                            <br />
                            <center>
                                <img src="../images/icon17.png" /><span class="heading">My IPD Patients</span>
                            </center>
                            <br />
                        </div>
                        <br />
                        <div id="div1">
                            <br />
                            <div id="div2">
                                <br />
                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                    <asp:ListItem Value="1" Selected="True"><span class="span1">Current Patients</span></asp:ListItem>
                                    <asp:ListItem Value="2"><span class="span1">New Patients</span></asp:ListItem>
                                    <asp:ListItem Value="3"><span class="span1">Previous Patients</span></asp:ListItem>
                                    <asp:ListItem Value="4"><span class="span1">All Patients</span></asp:ListItem>
                                </asp:RadioButtonList>
                                <br />
                                <table>
                                    <tr>
                                        <td>
                                            <span class="span1">Patient Name:</span>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" Width="150"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" OnClick="Button1_Click"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <br />
                            <asp:GridView ID="GridView1" RowStyle-BackColor="OldLace" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1100px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="ID" Visible="false"/>                                    
                                    <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient" ItemStyle-Width="150" />
                                    <asp:BoundField DataField="WARD_NAME" HeaderText="Ward Name" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="WARD_NUMBER" HeaderText="Ward Number" ItemStyle-Width="60"/>
                                    <asp:BoundField DataField="ADMISSION_DATE" HeaderText="Admission Date" ItemStyle-Width="90" />
                                    <asp:BoundField DataField="LAST_OBSERVATION_DATE" HeaderText="Last Observation Date" ItemStyle-Width="120" />
                                    <asp:BoundField DataField="LAST_OBSERVATION_TIME" HeaderText="Last Observation Time" ItemStyle-Width="120" />
                                    <asp:BoundField DataField="NEXT_OBSERVATION_DATE" HeaderText="Next Observation Date" ItemStyle-Width="125" />
                                    <asp:BoundField DataField="NEXT_OBSERVATION_TIME" HeaderText="Next Observation Time" ItemStyle-Width="125" />
                                    <asp:ButtonField HeaderText="Details" Text="View Details" CommandName="Select" ItemStyle-Width="90" />
                                </Columns>
                            </asp:GridView>
                            <asp:GridView ID="GridView2" RowStyle-BackColor="OldLace" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView2_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1160px" OnPageIndexChanging="GridView2_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="ID" Visible="false"/>
                                    <asp:BoundField DataField="DOCTOR_NAME" HeaderText="Doctor" />
                                    <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient" />
                                    <asp:BoundField DataField="TRANSFER_DATE" HeaderText="Transfer Date"/>
                                    <asp:BoundField DataField="TRANSFER_TIME" HeaderText="Transfer Time" />
                                    <asp:BoundField DataField="REASON_FOR_TRANSFER" HeaderText="Remarks" />
                                    <asp:BoundField DataField="DISCHARGE_DATE" HeaderText="Discharge Date" />
                                    <asp:ButtonField HeaderText="View" Text="View" CommandName="Select" />
                                </Columns>
                            </asp:GridView>
                            <asp:GridView ID="GridView3" RowStyle-BackColor="OldLace" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView3_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="930px" OnPageIndexChanging="GridView3_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                                <Columns>
                                    <asp:BoundField DataField="ID" Visible="false"/>                                    
                                    <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient" ItemStyle-Width="150" />
                                    <asp:BoundField DataField="WARD_NAME" HeaderText="Ward Name" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="WARD_NUMBER" HeaderText="Ward Number" ItemStyle-Width="60"/>
                                    <asp:BoundField DataField="ADMISSION_DATE" HeaderText="Admission Date" ItemStyle-Width="90" />
                                    <asp:BoundField DataField="ADMISSION_TIME" HeaderText="Admission Time" ItemStyle-Width="90" />
                                    <asp:ButtonField HeaderText="Details" Text="View Details" CommandName="Select" ItemStyle-Width="90" />
                                </Columns>
                            </asp:GridView>
                            <b><asp:Label ID="Label1" runat="server" Text="No Patients To Display" Visible="false" ForeColor="Red"></asp:Label></b>
                        </div>
                    </div>
                </center>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="GridView1" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
