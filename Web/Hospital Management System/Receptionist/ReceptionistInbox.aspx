<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistInbox.aspx.cs" Inherits="css_Receptionist_ReceptionistInbox" MasterPageFile="~/Receptionist/ReceptionistMasterPage.master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">

    <link rel="stylesheet" href="../css/Receptionist/ReceptionistInboxStyle.css" />
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
     <div class="style2" id="div5">
        <br />
        <table id="table1" border="0">
                <tr>
                <td colspan="3">
                    <center>
                        <img src="../images/icon17.png" height="40" width="40" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Inbox" CssClass="label"></asp:Label>
                        <hr />
                    </center>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <center>
                        <b>Select Action:</b>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>--Select--</asp:ListItem>
                            <asp:ListItem>Forward</asp:ListItem>
                            <asp:ListItem>Reply</asp:ListItem>
                            <asp:ListItem>Delete</asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Go" CssClass="button" />
                    </center>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <center>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" HeaderStyle-BackColor="YellowGreen" AlternatingRowStyle-BackColor="Wheat" Width="850">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                            <Columns>
                                <asp:BoundField HeaderText="ID" DataField="ID" Visible="false" />
                                <asp:BoundField HeaderText="Sender" DataField="SENDER" ItemStyle-Width="200" />
                                <asp:HyperLinkField HeaderText="Subject" DataTextField="MESSAGE_SUBJECT" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/Receptionist/ReceptionistViewMessage.aspx?messageId={0}" />
                                <asp:BoundField HeaderText="Date" DataField="MESSAGE_DATE" ItemStyle-Width="130" />
                                <asp:BoundField HeaderText="Time" DataField="MESSAGE_TIME" ItemStyle-Width="130" />
                            </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

<RowStyle HorizontalAlign="Center"></RowStyle>
                        </asp:GridView>
                    </center>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
