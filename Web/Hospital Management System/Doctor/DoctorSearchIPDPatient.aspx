<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorSearchIPDPatient.aspx.cs" Inherits="Doctor_DoctorSearchIPDPatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorSearchIPDPatientStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                    <div>
                        <center>
                            <img src="../images/icon2.png" /><span class="heading">Register IPD Patient</span>
                        </center>
                        <a href="#" onclick="window.close();">Close Window</a>
                        <br />
                        <br />
                        <fieldset>
                            <legend>Search Patient</legend>           
                            <br />
                            <table id="table1">
                                <tr>
                                    <td class="td1">
                                        <span class="span1"><b style="color:red">*</b>Patient Name:</span>
                                    </td>
                                    <td class="td1">
                                        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="ValidationGroup1" Width="200px"></asp:TextBox>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter patient name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter patient name in correct format" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="ValidationGroup1"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" OnClick="Button1_Click" ValidationGroup="ValidationGroup1"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView1" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="700px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast">
    <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                                <Columns>
                                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" >
                                    <ControlStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" />
                                    <asp:BoundField DataField="PATIENT_PRIMARY_PHONE" HeaderText="Patient Phone No." ItemStyle-Width="150" >
    <ItemStyle Width="150px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField DataField="WARD_NAME" HeaderText="Ward" />
                                    <asp:BoundField DataField="WARD_NUMBER" HeaderText="Ward Number" />
                                    <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" />  
                                </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                                <PagerSettings Mode="NumericFirstLast" />
                                <PagerStyle BackColor="#99FF99" HorizontalAlign="Center" VerticalAlign="Middle" />

<RowStyle HorizontalAlign="Center"></RowStyle>
                            </asp:GridView>
                            <b><asp:Label ID="Label1" runat="server"></asp:Label></b>
                        </fieldset>
                    </div>
                </center>
            </div>
    </form>
</body>
</html>
