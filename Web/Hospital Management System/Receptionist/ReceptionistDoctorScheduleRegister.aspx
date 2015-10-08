<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistDoctorScheduleRegister.aspx.cs" Inherits="Receptionist_ReceptionistAttendanceRegister"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistDoctorScheduleRegisterStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <div id="center1">
            <br />
            <center>
                <img src="../images/icon8.png" /><span class="heading">Doctor Schedule Register</span>
            </center>
            <br />
        </div>
        <br />
                <div id="div1">
                    <center>
                        <div>
                            <br />
                            <center>
                                <fieldset id="fieldset1">
                                    <legend>Search Doctor</legend>           
                                    <br />
                                    <table>
                                        <tr>
                                            <td>
                                                <b>Enter Doctor Name:</b>
                                            </td>
                                            <td>&nbsp;&nbsp;
                                                <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="ValidationGroup1" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter patient name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter patient name in correct format" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="ValidationGroup1"></asp:RegularExpressionValidator>
                                            </td>
                                            <td>&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" OnClick="Button1_Click" ValidationGroup="ValidationGroup1"></asp:Button>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    <asp:GridView RowStyle-BackColor="OldLace" ID="GridView1" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="500px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" >
                                            <ControlStyle ForeColor="White" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="DOCTOR_NAME" HeaderText="Doctor Name" />
                                            <asp:BoundField DataField="DOCTOR_DEPARTMENT" HeaderText="Doctor Department" ItemStyle-Width="150" >
            <ItemStyle Width="150px"></ItemStyle>
                                            </asp:BoundField>
                                            <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" />                                        
                                        </Columns>

            <HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                                        <PagerSettings Position="Bottom" Mode="NumericFirstLast" />
                                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

            <RowStyle HorizontalAlign="Center"></RowStyle>
                                    </asp:GridView>
                                    <b><asp:Label ID="Label1" runat="server" Text="No Doctor Found" Visible="false" ForeColor="Red"></asp:Label></b>
                                    <br />
                                </fieldset>
                                <br />
                            </center>
                        </div>
                    </center>
                </div>

    </form>
</body>
</html>