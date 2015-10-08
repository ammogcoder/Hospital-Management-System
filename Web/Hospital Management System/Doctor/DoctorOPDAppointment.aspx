<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorOPDAppointment.aspx.cs" Inherits="Doctor_DoctorSelectOPDPatient" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorOPDAppointmentStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>                                                       
                <div>
                    <center>
                        <div>
                            <div id="center1">
                                <br />
                                <center>
                                    <img src="../images/icon17.png" /><span class="heading">OPD Appointment Prescription</span>
                                </center>
                                <br />
                            </div>
                            <br />
                            <div id="div4">
                                <div>
                                    <br />
                                    <fieldset id="fieldset4">
                                        <legend id="legend5">Search Patient Appointment</legend>
                                         <table id="table4">
                                            <tr>
                                                <td class="td3">
                                                    <span class="span1"><b style="color:red">*</b>Appointment Token:</span>
                                                </td>
                                                <td class="td4">
                                                    <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="ValidationGroup1" Width="200px"></asp:TextBox>
                                                    <br />
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter appointment token" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter appointment token in correct format" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]*" ValidationGroup="ValidationGroup1"></asp:RegularExpressionValidator>
                                                </td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Button ID="Button3" runat="server" Text="Search" CssClass="button" OnClick="Button3_Click" ValidationGroup="ValidationGroup1"></asp:Button>
                                                </td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                    <asp:Panel ID="Panel1" runat="server" Visible="false">
                                        <br />
                                        <fieldset id="fieldset5">
                                            <legend id="legend7">Patient Details</legend>
                                            <table id="table3" border="1">
                                                <tr class="tr1">
                                                    <td>
                                                        Patient Name:
                                                    </td>
                                                    <td>
                                                        <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                                                    </td>
                                                </tr>
                                                <tr class="tr2">
                                                    <td>
                                                        Patient DOB:
                                                    </td>
                                                    <td>
                                                        <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                                                    </td>
                                                </tr>
                                                <tr class="tr1">
                                                    <td>
                                                        Patient Phone No.
                                                    </td>
                                                    <td>
                                                        <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                                                    </td>
                                                </tr>
                                            </table>
                                        </fieldset>
                                    </asp:Panel>
                                    <br />
                                    <asp:Label ID="Label5" runat="server" Width="98%" Font-Bold="true"></asp:Label>&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" Visible="false">Print Prescription Report</asp:LinkButton>
                                    <br />
                                </div>
                                <asp:Panel ID="Panel2" runat="server" Visible="false">                               
                                <fieldset id="fieldset1">
                                    <legend id="legend1">Prescription Details</legend>
                                    <table id="table1">
                                        <tr>
                                            <td class="td1">
                                                <span class="span1"><b style="color:red">*</b>Medicine Type:</span>
                                            </td>
                                            <td class="td2">
                                                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="MEDICINE_TYPE" DataValueField="ID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="130px"></asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [MEDICINE_TYPE_TABLE]"></asp:SqlDataSource>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please select medicine type" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td1">
                                                <span class="span1"><b style="color:red">*</b>Medicine:</span>
                                            </td>
                                            <td class="td2">
                                                <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" Width="130px"></asp:DropDownList>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please select medicine name" ControlToValidate="DropDownList2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td1">
                                                <span class="span1">Strength:</span>
                                            </td>
                                            <td class="td2">
                                                <asp:TextBox ID="TextBox1" runat="server" Width="130px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Quantity:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox4" runat="server" Width="130px"></asp:TextBox>
                                                <br />
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter quantity" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td1">
                                                <span class="span1"><b style="color:red">*</b>Start Date:</span>
                                            </td>
                                            <td class="td2">
                                                <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox5" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                <asp:TextBox ID="TextBox5" runat="server" Width="130px"></asp:TextBox>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select start date" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td1">
                                                <span class="span1"><b style="color:red">*</b># Refills:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" Width="130px"></asp:TextBox>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter no. of refills" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ErrorMessage="Please enter no. of refills in correct format" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]*" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="td1">
                                                <span class="span1">Quantity on Refills:</span> 
                                            </td>
                                            <td class="td2">
                                                <asp:TextBox ID="TextBox6" runat="server" Width="130px"></asp:TextBox>
                                            </td>
                                        <tr>
                                            <td class="td1">
                                                <span class="span1">Instructions:</span> 
                                            </td>
                                            <td class="td2">
                                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Button ID="Button1" runat="server" CssClass="button" Text="Add Medicine" ValidationGroup="ValidationGroup2" OnClick="Button1_Click" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="Button2" runat="server" CssClass="button" Text="Reset" CausesValidation="False" />
                                            </td>
                                        </tr>
                                    </table>                     
                                </fieldset>
                                <asp:Panel ID="Panel4" runat="server" Visible="false">
                                    <fieldset id="fieldset6">
                                        <legend id="legend3">Current Prescription</legend>
                                        <div id="div2">
                                            <asp:GridView ID="GridView3" runat="server" DataKeyNames="ID" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" RowStyle-BackColor="OldLace" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="900px" OnRowDataBound="GridView3_RowDataBound">
                                                <Columns>
                                                    <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                                    <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" />
                                                    <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                                    <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Strength" />
                                                    <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Quantity" />
                                                    <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Start Date" />
                                                    <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="# Refills" />
                                                    <asp:BoundField DataField="MEDICINE_QUANTITY_ON_REFILLS" HeaderText="Quantity on Refills" />
                                                    <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Instructions" />
                                                    <asp:TemplateField HeaderText="Delete">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Delete</asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                        </div>                                
                                    </fieldset>
                                </asp:Panel>
                                <fieldset id="fieldset3">
                                    <legend id="legend4">Treatment Diagnosis</legend>
                                    <table>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Diagnosis:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter treatment diagnosis" ControlToValidate="TextBox8" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine" Width="910px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Button ID="Button4" runat="server" Text="Save Prescription" CssClass="button" OnClick="Button4_Click" ValidationGroup="ValidationGroup3"></asp:Button>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </asp:Panel>
                                <asp:Panel ID="Panel3" runat="server" Visible="false">
                                <fieldset id="fieldset2">
                                    <legend id="legend2">Patient Treatment History</legend>
                                        <table>
                                            <tr>
                                                <td>
                                                    <div id="div1">
                                                        <table id="table2" border="1">
                                                            <tr>
                                                                <td id="td1">
                                                                    Doctor
                                                                </td>
                                                                <td id="td2">
                                                                    Visit Date
                                                                </td>
                                                                <td id="td3">
                                                                    Visit Time
                                                                </td>
                                                                <td id="td4">
                                                                    Details
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="430px" OnRowDataBound="GridView1_RowDataBound" HeaderStyle-CssClass="header1" ShowHeader="False">
                                                            <Columns>
                                                                <asp:BoundField DataField="APPOINTMENT_TOKEN" HeaderText="Appointment Token" Visible="False" />
                                                                <asp:BoundField DataField="DOCTOR_NAME" HeaderText="Doctor" ItemStyle-Width="160px" />
                                                                <asp:BoundField DataField="APPOINTMENT_DATE" HeaderText="Visit Date" ItemStyle-Width="80px" />
                                                                <asp:BoundField DataField="APPOINTMENT_TIME" HeaderText="Visit Time" ItemStyle-Width="70px" />
                                                                <asp:CommandField HeaderText="Details" ShowSelectButton="true" ItemStyle-Width="60px" />
                                                            </Columns>
                                                        </asp:GridView>
                                                    </div>
                                                </td>
                                                <td>
                                                    <div id="div3">
                                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="900px" OnRowDataBound="GridView2_RowDataBound">
                                                            <Columns>
                                                                <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                                                <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" />
                                                                <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                                                <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Strength" />
                                                                <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Quantity" />
                                                                <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Start Date" />
                                                                <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="# Refills" />
                                                                <asp:BoundField DataField="MEDICINE_QUANTITY_ON_REFILLS" HeaderText="Quantity on Refills" />
                                                                <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Instructions" />
                                                            </Columns>
                                                        </asp:GridView>
                                                    </div>
                                                </td>
                                            </tr>
                                        </table>                                                           
                                    </fieldset>
                                    <br />
                                </asp:Panel>
                            </div>
                        </div>
                    </center>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="GridView1" />
                <asp:PostBackTrigger ControlID="GridView3" />
                <asp:PostBackTrigger ControlID="Button1" />
                <asp:PostBackTrigger ControlID="Button3" />
                <asp:PostBackTrigger ControlID="LinkButton2" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
