<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorViewIPDObservationReportMedicine.aspx.cs" Inherits="Doctor_DoctorViewIPDObservationReportMedicine" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorViewIPDObservationReportMedicineStyle.css"
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <center>
                    <div>
                        <fieldset>
                            <legend>IPD Report Medicines</legend>
                            <a href="#" onclick="window.close();">Close Window</a>
                            <br />
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="1020px" OnPageIndexChanging="GridView1_PageIndexChanging" PagerStyle-BackColor="#99FF99" PagerStyle-BorderColor="#66FFCC" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle">
                                <Columns>
                                    <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" ItemStyle-Width="130" />
                                    <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                    <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Medicine Strength" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Medicine Quantity" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Medicine Start Date" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="Medicine Number Of Refills" ItemStyle-Width="100" />
                                    <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Medicine Instructions" />
                                </Columns>
                            </asp:GridView>
                            <b><asp:Label ID="Label1" runat="server" Text="No Medicines To Display" Visible="false" ForeColor="Red"></asp:Label></b>
                        </fieldset>
                    </div>
                </center>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
