<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistAccountInfo.aspx.cs" Inherits="Receptionist_RecepionistAccountInfo" MasterPageFile="~/Receptionist/ReceptionistMasterPage.master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">

    <link rel="stylesheet" href="../css/Receptionist/ReceptionistAccountInfoStyle.css" />
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="style2" id="div5">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table id="table1">
                    <tr>
                        <td colspan="2">
                            <img src="../images/icon15.png" height="50" width="50" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Account Information" CssClass="label"></asp:Label>
                            <hr />
                            <br />
                            <center>
                                <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></b>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Update Password</asp:LinkButton>
                        </td>
                    </tr>
                    <asp:Panel ID="Panel1" runat="server" Visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="Current Password:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label17" runat="server" Text="New Password:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="Re-enter New Password:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <br />
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="The two passwords do not match" ControlToValidate="TextBox3" ControlToCompare="TextBox2" SetFocusOnError="True" Display="Dynamic" ForeColor="Red"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Change Password" CssClass="button" OnClick="Button1_Click" />
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" OnClick="Button2_Click" />
                            </td>
                        </tr>
                    </asp:Panel>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Account Creation Date:"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></b>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Last Login:"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></b>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text="Primary Phone Number"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></b>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Update Primary Phone Number</asp:LinkButton>
                        </td>
                    </tr>
                    <asp:Panel ID="Panel4" runat="server" Visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="Label21" runat="server" Text="Enter New Primary Phone Number:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button7" runat="server" Text="Update Primary Phone Number" CssClass="button" OnClick="Button7_Click" />
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button8" runat="server" Text="Cancel" CssClass="button" OnClick="Button8_Click" />
                            </td>
                        </tr>
                    </asp:Panel>
                    <tr>
                        <td>
                            <asp:Label ID="Label12" runat="server" Text="Secondary Phone Number"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></b>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">LinkButton</asp:LinkButton>
                        </td>
                    </tr>
                    <asp:Panel ID="Panel3" runat="server" Visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="Label20" runat="server" Text="Enter New Secondary Phone Number:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button5" runat="server" Text="" CssClass="button" OnClick="Button5_Click" />
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button6" runat="server" Text="Cancel" CssClass="button" OnClick="Button6_Click" />
                            </td>
                        </tr>
                    </asp:Panel>
                    <tr>
                        <td>
                            <asp:Label ID="Label14" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <b><asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></b>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">LinkButton</asp:LinkButton>
                        </td>
                    </tr>
                     <asp:Panel ID="Panel2" runat="server" Visible="false">
                        <tr>
                            <td>
                                <asp:Label ID="Label19" runat="server" Text="Enter New Email Address:"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button3" runat="server" Text="" CssClass="button" OnClick="Button3_Click" />
                            </td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button4" runat="server" Text="Cancel" CssClass="button" OnClick="Button4_Click" />
                            </td>
                        </tr>
                    </asp:Panel>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
