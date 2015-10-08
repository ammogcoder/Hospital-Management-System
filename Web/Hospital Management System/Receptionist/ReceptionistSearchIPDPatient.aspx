<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistSearchIPDPatient.aspx.cs" Inherits="Receptionist_ReceptionistViewAllPatientInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistSearchIPDPatientStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="center1">
            <br />
            <center>
                <img src="../images/icon2.png" /><span class="heading">Search IPD Patient</span>
            </center>
            <br />
        </div>
 <div>
     <br />
    <center>
        <div id="div1">
            <br />
            <div>
                <fieldset id="fieldset1">
                    <legend id="legend1">Search Patient</legend>
                    <table>
                        <tr>
                            <td>
                                <span class="span1"><b style="color:red">*</b>Enter Patient Name:</span>
                                <br />
                                <br />
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <br />&nbsp;&nbsp;&nbsp;&nbsp
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter patient name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter patient name in correct format" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="ValidationGroup1"></asp:RegularExpressionValidator>
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" OnClick="Button1_Click" ValidationGroup="ValidationGroup1"></asp:Button>
                                <br />
                                <br />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:GridView ID="GridView1" RowStyle-BackColor="OldLace" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="700px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" >
                            <ControlStyle ForeColor="White" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" />
                            <asp:BoundField DataField="PATIENT_PRIMARY_PHONE" HeaderText="Phone No." ItemStyle-Width="150" >
    <ItemStyle Width="150px"></ItemStyle>
                            </asp:BoundField>
                            <asp:BoundField DataField="WARD_NAME" HeaderText="Ward Name" ItemStyle-Width="150" >
    <ItemStyle Width="150px"></ItemStyle>
                            </asp:BoundField>
                                <asp:BoundField DataField="WARD_NUMBER" HeaderText="Ward Number" ItemStyle-Width="80" >
    <ItemStyle Width="100px"></ItemStyle>
                            </asp:BoundField>
                            <asp:CommandField HeaderText="Details" ShowSelectButton="true" />
                        </Columns>

    <HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

    <RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                    <b><asp:Label ID="Label1" runat="server" Text="No Patient Found" Visible="false" ForeColor="Red" Font-Bold="true"></asp:Label></b>
                    <br />
                </fieldset>
                <br />
                </div>
            </div>
        </center>
    </div>
    </form>
</body>
</html>    
 