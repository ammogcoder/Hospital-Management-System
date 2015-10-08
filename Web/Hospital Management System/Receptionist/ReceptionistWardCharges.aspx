<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistWardCharges.aspx.cs" Inherits="Receptionist_ReceptionistWardCharges" MasterPageFile="~/Receptionist/ReceptionistMasterPage.master" %>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">

    <link rel="stylesheet" href="../css/Receptionist/ReceptionistWardChargesStyle.css" />
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="style2" id="div5">
                <center>
                    <table>
                        <tr>
                            <td colspan="2">
                                <center>
                                    <h3>Ward Charge Details</h3>
                                    <hr />
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <b><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <b><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <b><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <b><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <b><asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></b>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table>
                        <tr>
                            <td colspan="2">
                                <center>
                                    <h3>Enter Ward Charges</h3>
                                    <hr />
                                    <asp:Label ID="Label16" runat="server" BackColor="Yellow"></asp:Label>
                                </center>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter charge for suite ward" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter charge for delux ward" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter charge for special AC ward" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter charge for semi private ward " ControlToValidate="TextBox4" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <b><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></b>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter charge for general ward" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </center>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>