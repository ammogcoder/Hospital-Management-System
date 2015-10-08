<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistIPDPatientWardTransfer.aspx.cs" Inherits="Receptionist_ReceptionistSearchIPDPatientForWardTransfer" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistIPDPatientWardTransferStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistSearchIPDPatientForWardTransferScript.js"></script>
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
                                <img src="../images/icon24.png" /><span class="heading">IPD Patient Ward Transfer</span>
                            </center>
                            <br />
                        </div>
                    <center>
                        <br />
                        <br />
                        <div id="div1">
                            <br />
                            <br />
                            <fieldset id="fieldset1">
                                <legend id="legend1">Search Patient</legend>
                                <br />    
                                <table id="table1">
                                    <tr>
                                        <td class="td1">
                                            <b style="color:red">*</b><span class="span1">Enter Patient Name:</span>
                                            <br />
                                            <br />
                                        </td>
                                        <td class="td1">
                                            <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox1" Width="200px"></asp:TextBox>
                                            <br />
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
                                <asp:GridView ID="GridView1" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="700px" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" RowStyle-BackColor="OldLace">
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
                                        <asp:BoundField DataField="ADMIT_DATE" HeaderText="Admit Date" Visible="False" />
                                        <asp:BoundField DataField="WARD_ID" HeaderText="Ward ID" Visible="False" />
                                        <asp:CommandField HeaderText="Select" ShowSelectButton="true" />
                                    </Columns>

            <HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                                    <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

            <RowStyle HorizontalAlign="Center"></RowStyle>
                                </asp:GridView>
                                <b><asp:Label ID="Label1" runat="server" Visible="false"></asp:Label></b>
                            </fieldset>
                            <br />
                            <br />
                            <asp:Panel ID="Panel1" runat="server" Visible="false" Width="500px" CssClass="panel1">
                                <br />
                                <br />
                                <fieldset id="fieldset2">
                                    <legend id="legend2">Ward Transfer Details</legend>
                                    <div>
                                        <table id="table2" style="background-color:aliceblue;">
                                            <tr style="background-color:lightgreen">
                                                <td>
                                                    <span class="span1">Patient Name:</span>
                                                </td>
                                                <td>
                                                    <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                                                </td>
                                            </tr>
                                            <tr style="background-color:lightgreen">
                                                <td >
                                                    <span class="span1">Current Ward:</span>
                                                </td>
                                                <td>
                                                    <b><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></b>
                                                </td>
                                            </tr>
                                            <tr style="background-color:lightgreen">
                                                <td>
                                                    <span class="span1">Current Ward No:</span>
                                                </td>
                                                <td>
                                                    <b><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></b>
                                                </td>
                                            </tr>
                                            <tr style="background-color:lightgreen">
                                                <td>
                                                    <span class="span1">Admit Date:</span>
                                                </td>
                                                <td>
                                                    <b><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b style="color:red">*</b><span class="span1">Transfer Date:</span>
                                                </td>
                                                <td>
                                                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox3" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                    <asp:TextBox ID="TextBox3" runat="server" Width="200"></asp:TextBox>
                                                    <br />
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter transfer date" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b style="color:red">*</b><span class="span1">Transfer Time:</span>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox4" runat="server" Width="200"></asp:TextBox>
                                                    <br />
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter transfer time" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp; 
                                                    <b style="color:red">*</b><span class="span1">Reason For Transfer:</span>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="200"></asp:TextBox>
                                                    <br />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter reason for transfer" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b style="color:red">*</b><span class="span1">Select New Ward:</span>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="WARD_NAME" DataValueField="ID" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200"></asp:DropDownList>
                                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT [ID], [WARD_NAME] FROM [WARD_TABLE]"></asp:SqlDataSource>
                                                    <br />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please select new ward" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b style="color:red">*</b><span class="span1">Select New Ward No:</span>
                                                </td>
                                                <td>
                                                    <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" Width="200"></asp:DropDownList>
                                                    <br />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please select new ward number" ControlToValidate="DropDownList2" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    <br />
                                                    <center>
                                                        <asp:Button ID="Button2" runat="server" Text="Transfer Patient" CssClass="button" OnClick="Button2_Click" ValidationGroup="ValidationGroup2"></asp:Button>
                                                        &nbsp;&nbsp;&nbsp;
                                                        <asp:Button ID="Button3" runat="server" Text="Reset" CssClass="button" OnClick="Button3_Click" CausesValidation="False"></asp:Button>
                                                    </center>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </fieldset>
                            </asp:Panel>    
                        </div>
                    </center>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>    
 