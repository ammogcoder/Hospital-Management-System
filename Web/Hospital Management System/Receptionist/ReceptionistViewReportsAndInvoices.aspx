<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistViewReportsAndInvoices.aspx.cs" Inherits="Receptionist_ReceptionistViewReportsAndInvoices" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistViewReportsAndInvoicesStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <div id="center1">
                        <br />
                        <center>
                            <img src="../images/icon18.png" /><span class="heading">View Reports & Invoices</span>                            
                        </center>
                        <br />
                    </div>
                    <br />
                    <div id="div1">
                        <center>
                            <div>
                                <br />
                                <fieldset>
                                    <legend>Select Report/Invoice Type</legend>
                                    <br />
                                    <table id="table1">
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Select Report/Invoice Type:</span>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                                                    <asp:ListItem Value="1">Appointment Invoice</asp:ListItem>
                                                    <asp:ListItem Value="2">Medical Test Registration Invoice</asp:ListItem>
                                                    <asp:ListItem Value="3">IPD Registration Report</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                    </table>
                                    <asp:MultiView ID="MultiView1" runat="server">
                                        <asp:View ID="View1" runat="server">
                                            <br />
                                            <asp:GridView ID="GridView1" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" AllowPaging="True" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="700px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast" PageSize="10">
                                                <AlternatingRowStyle BackColor="Wheat" />
                                                <Columns>
                                                    <asp:BoundField HeaderText="INVOICE_ID" Visible="False" DataField="INVOICE_ID" />
                                                    <asp:BoundField HeaderText="Invoice Date" DataField="INVOICE_DATE" />
                                                    <asp:BoundField HeaderText="Patient Name" DataField="PATIENT_NAME" />
                                                    <asp:BoundField HeaderText="Doctor Name" DataField="DOCTOR_NAME" />
                                                    <asp:CommandField HeaderText="Select" ShowSelectButton="true" />
                                                </Columns>
                                                <HeaderStyle BackColor="YellowGreen" />
                                                <PagerSettings Mode="NumericFirstLast" />
                                                <PagerStyle BackColor="#99FF99" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <RowStyle HorizontalAlign="Center" />
                                            </asp:GridView>
                                        </asp:View>
                                        <asp:View ID="View2" runat="server">
                                            <br />
                                            <asp:GridView ID="GridView2" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" AllowPaging="True" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="700px" OnPageIndexChanging="GridView2_PageIndexChanging" OnRowDataBound="GridView2_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast">
                                                <AlternatingRowStyle BackColor="Wheat" />
                                                <Columns>
                                                    <asp:BoundField HeaderText="INVOICE_ID" Visible="False" DataField="INVOICE_ID" />
                                                    <asp:BoundField HeaderText="Invoice Date" DataField="INVOICE_DATE" />
                                                    <asp:BoundField HeaderText="Patient Name" DataField="PATIENT_NAME" />
                                                    <asp:CommandField HeaderText="Select" ShowSelectButton="true" />
                                                </Columns>
                                                <HeaderStyle BackColor="YellowGreen" />
                                                <PagerSettings Mode="NumericFirstLast" />
                                                <PagerStyle BackColor="#99FF99" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <RowStyle HorizontalAlign="Center" />
                                            </asp:GridView>
                                        </asp:View>
                                        <asp:View ID="View3" runat="server">
                                            <br />
                                            <asp:GridView ID="GridView3" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" AllowPaging="True" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" Width="700px" OnPageIndexChanging="GridView3_PageIndexChanging" OnRowDataBound="GridView3_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast">
                                                <AlternatingRowStyle BackColor="Wheat" />
                                                <Columns>
                                                    <asp:BoundField HeaderText="REPORT_ID" Visible="False" DataField="REPORT_ID" />
                                                    <asp:BoundField HeaderText="Report Date" DataField="REPORT_DATE" />
                                                    <asp:BoundField HeaderText="Patient Name" DataField="PATIENT_NAME" />
                                                    <asp:CommandField HeaderText="Select" ShowSelectButton="true" />
                                                </Columns>
                                                <HeaderStyle BackColor="YellowGreen" />
                                                <PagerSettings Mode="NumericFirstLast" />
                                                <PagerStyle BackColor="#99FF99" HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <RowStyle HorizontalAlign="Center" />
                                            </asp:GridView>
                                        </asp:View>
                                    </asp:MultiView>
                                </fieldset>
                                <br />
                            </div>
                        </center>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="GridView1" />
                <asp:PostBackTrigger ControlID="GridView2" />
                <asp:PostBackTrigger ControlID="GridView3" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
