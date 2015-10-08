<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistCreateNewMessage.aspx.cs" Inherits="Receptionist_ReceptionistCreateNewMessage"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistCreateNewMessageStyle.css" />
    <script type="text/javascript" src="../js/Receptionist/ReceptionistCreateNewMessageScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <div>
         <div>     
            <center>                                                
                <div>
                    <center>
                        <img src="../images/icon1.ico" /><span class="heading">Create New Message</span>
                    </center>
                    <br />
                    <a href="#" onclick="window.close();">Close Window</a>
                    <br />
                    <br />
                    <center>
                        <table id="table1">
                            <tr>
                                <td>
                                    <span class="span1"><b style="color:red">*</b>Subject</span>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span class="span1"><b style="color:red">*</b>Recepient</span>
                                </td>
                                <td>
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                    <br />
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Select Recepient(s)</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </center>
                </div>
            </center>
        </div>
        <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="Label2" BackgroundCssClass="modalBackground" CancelControlID="Button2"></asp:ModalPopupExtender>
            <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" ScrollBars="Auto">
                <center>
                    <table>
                        <tr>
                            <td>
                                Select Department:
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="SPECIALITY" DataValueField="ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [DEPARTMENT_TABLE]"></asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="Button2" runat="server" Text="Close Window" OnClick="Button2_Click" CssClass="button"></asp:Button>
                            </td>
                        </tr>  
                    </table>
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="400px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast" PageSize="10">
                    <Columns>
                        <asp:TemplateField HeaderText="Select">
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
                        <asp:BoundField DataField="DOCTOR_NAME" HeaderText="Doctor Name" />
                        <asp:BoundField DataField="DEPARTMENT" HeaderText="Department" />
                    </Columns>
                    <PagerSettings Mode="NumericFirstLast" />
                    <PagerStyle BackColor="#99FF99" HorizontalAlign="Center" VerticalAlign="Middle" />
                    <RowStyle HorizontalAlign="Center" />
                </asp:GridView>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Select Recepient(s)" Visible="false" CssClass="button" OnClick="Button3_Click"></asp:Button>
            </center>
        </asp:Panel>
    </div>
    </form>
</body>
</html>