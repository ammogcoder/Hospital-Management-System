<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorIPDObservation.aspx.cs" Inherits="Doctor_DoctorIPDObservation" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Doctor/DoctorIPDObservationStyle.css" />
        <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Doctor/DoctorIPDObservationScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
            <div>
                    <center>
                        <div>
                            <div id="center1">
                                <br />
                                <center>
                                    <img src="../images/icon2.png" /><span class="heading">IPD Observation</span>
                                </center>
                                <br />
                            </div>
                            <br />
                            <div id="div1">
                                <br />
                                <fieldset id="fieldset2">
                                    <legend id="legend1">Search Patient</legend>           
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
                                    <br />
                                    <br />
                                    <asp:GridView ID="GridView1" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="700px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast" RowStyle-BackColor="OldLace">
            <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                                        <Columns>
                                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" />
                                            <asp:BoundField DataField="WARD_ID_FK" HeaderText="WARD_ID" ReadOnly="True" Visible="False" />
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
                                <asp:Panel ID="Panel1" runat="server" Visible="false">
                                <br />
                                <br />
                                <fieldset id="fieldset5">
                                    <legend id="legend2">IPD Observation Report</legend>
                                    <br />
                                    <table id="table2">
                                    <tr>
                                        <td>
                                            <span class="span1"><b style="color:red">*</b>Observation Date:</span>
                                        </td>
                                        <td>
                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox8" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                            <asp:TextBox ID="TextBox8" runat="server" Width="150px"></asp:TextBox>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please enter observation date" ControlToValidate="TextBox8" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox8" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                        </td>
                                        <td>
                                            <span class="span1"><b style="color:red">*</b>Observation Time:</span>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox9" runat="server" Width="150px"></asp:TextBox>
                                            <br />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox9" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please enter observation time" ControlToValidate="TextBox9" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="span1"><b style="color:red">*</b>Patient Health Condition:</span>
                                        </td>
                                        <td>
                                            <span class="span1"><asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" DataSourceID="SqlDataSource1" DataTextField="PATIENT_GENERAL_HEALTH" DataValueField="ID">
                                            </asp:RadioButtonList></span>
                                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [PATIENT_GENERAL_HEALTH]"></asp:SqlDataSource>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please select patient health condition" ControlToValidate="RadioButtonList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr> 
                                        <td>
                                            <center>
                                                <asp:Button ID="Button8" runat="server" Text="Ward Transfer" CssClass="button" OnClientClick="openWardTransferWindow();return false;"></asp:Button>
                                            </center>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td3" colspan="2">
                                            <br />
                                            <asp:HyperLink ID="HyperLink2" runat="server">View Observation History</asp:HyperLink>
                                            <br />
                                            <asp:HyperLink ID="HyperLink1" runat="server">View Active Medicines</asp:HyperLink>
                                            <br />
                                            <asp:HyperLink ID="HyperLink5" runat="server">View Past Medical Tests</asp:HyperLink>
                                        </td>
                                        <td class="td3" colspan="2">
                                            <br />
                                            <asp:HyperLink ID="HyperLink3" runat="server">View All Medicines</asp:HyperLink>
                                            <br />
                                            <asp:HyperLink ID="HyperLink4" runat="server">View Past Observation Reports</asp:HyperLink>
                                        </td>
                                    </tr>
                                </table>
                                <asp:GridView ID="GridView2" runat="server" ShowFooter="True" GridLines="None" AutoGenerateColumns="false" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="aquamarine" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="700px" OnRowDataBound="GridView2_RowDataBound" PagerStyle-HorizontalAlign="Center" PagerStyle-VerticalAlign="Middle" PagerSettings-Mode="NumericFirstLast" OnRowDeleting="GridView2_RowDeleting">
                                    <Columns>
                                    <asp:BoundField DataField="RowNumber" HeaderText="SrNo." />
                                    <asp:TemplateField HeaderText="Problem">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="150px"></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Problem Details">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Width="150px"></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="System Review">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="150px"></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Assessment">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Width="150px"></asp:TextBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Plan">
                                        <ItemTemplate>
                                            <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Width="150px"></asp:TextBox>
                                        </ItemTemplate>
                                        <FooterStyle HorizontalAlign="Right" />
                                        <FooterTemplate>
                                            <asp:Button ID="Button2" runat="server" Text="Add Observation" OnClick="Button2_Click" CssClass="button"></asp:Button>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                                    <FooterStyle BackColor="aquamarine" Font-Bold="True" ForeColor="White" />
                                </asp:GridView>
                                <br />
                            </fieldset>
                            <br />
                            <fieldset id="fieldset1">
                                    <legend id="legend3">IPD Medicine Details</legend>
                                    <table id="table4">
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>For Observation:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:DropDownList ID="DropDownList6" runat="server" CssClass="select" AppendDataBoundItems="True"></asp:DropDownList>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please select observation" ControlToValidate="DropDownList6" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Medicine Type:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:DropDownList CssClass="select" ID="DropDownList4" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="MEDICINE_TYPE" DataValueField="ID" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" Width="130px"></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [MEDICINE_TYPE_TABLE]"></asp:SqlDataSource>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please select medicine type" ControlToValidate="DropDownList4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Medicine:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:DropDownList CssClass="select" ID="DropDownList5" runat="server" AppendDataBoundItems="True" Width="130px"></asp:DropDownList>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select medicine name" ControlToValidate="DropDownList5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1">Strength:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:TextBox ID="TextBox7" runat="server" Width="130px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <span class="span1"><b style="color:red">*</b>Quantity:</span>
                                        </td>
                                        <td>
                                            &nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="130px"></asp:TextBox>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter quantity" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Start Date:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:TextBox ID="TextBox5" runat="server" Width="130px"></asp:TextBox>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please select start date" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup3"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b># Refills:</span>
                                        </td>
                                        <td>
                                            &nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="130px"></asp:TextBox>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter no. of refills" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup3"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ErrorMessage="Please enter no. of refills in correct format" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="[0-9]*" ValidationGroup="ValidationGroup3"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1">Quantity on Refills:</span> 
                                        </td>
                                        <td class="td2">
                                            <asp:TextBox ID="TextBox6" runat="server" Width="130px"></asp:TextBox>
                                        </td>
                                    </tr>
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
                                            <br />
                                            <center>
                                                <asp:Button ID="Button3" runat="server" CssClass="button" Text="Add Medicine" ValidationGroup="ValidationGroup3" OnClick="Button3_Click" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="Button6" runat="server" CssClass="button" Text="Reset" CausesValidation="False" OnClick="Button6_Click" />
                                            </center>
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                                <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox5" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <asp:Panel ID="Panel2" runat="server" Visible="false">
                                    <div id="div3">
                                        <asp:GridView ID="GridView3" RowStyle-BackColor="OldLace" Visible="false" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="900px" OnRowDataBound="GridView3_RowDataBound" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                                            <Columns>
                                                <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                                <asp:BoundField DataField="IPD_OBSERVATION_REPORT_ID_FK" HeaderText="Observation No." />
                                                <asp:BoundField DataField="MEDICINE_TYPE" HeaderText="Medicine Type" />
                                                <asp:BoundField DataField="MEDICINE_NAME" HeaderText="Medicine Name" />
                                                <asp:BoundField DataField="MEDICINE_STRENGTH" HeaderText="Strength" />
                                                <asp:BoundField DataField="MEDICINE_QUANTITY" HeaderText="Quantity" />
                                                <asp:BoundField DataField="MEDICINE_START_DATE" HeaderText="Start Date" />
                                                <asp:BoundField DataField="MEDICINE_NUMBER_OF_REFILLS" HeaderText="# Refills" />
                                                <asp:BoundField DataField="MEDICINE_QUANTITY_ON_REFILLS" HeaderText="Quantity on Refills" />
                                                <asp:BoundField DataField="MEDICINE_INSTRUCTIONS" HeaderText="Instructions" />
                                                <asp:ButtonField HeaderText="Delete" Text="Delete" CommandName="Select" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </asp:Panel>
                            </fieldset>
                            <br />
                            <fieldset id="fieldset3">
                                <asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="TextBox10" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                <legend id="legend4">IPD Medical Test Details</legend>
                                <table id="table3">
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>For Observation:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="select"></asp:DropDownList>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please select observation" ControlToValidate="DropDownList2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup4"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Select Test:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="select" AppendDataBoundItems="True" DataSourceID="SqlDataSource2" DataTextField="MEDICAL_TEST" DataValueField="ID"></asp:DropDownList>
                                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT [ID], [MEDICAL_TEST] FROM [MEDICAL_TEST_TABLE]"></asp:SqlDataSource>
                                            <br />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please select medical test" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup4" InitialValue="0"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Test Date:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:TextBox ID="TextBox10" runat="server" Width="130px"></asp:TextBox>
                                            <br />
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please select test date" ControlToValidate="TextBox10" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup4"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox10" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup4"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="td1">
                                            <span class="span1"><b style="color:red">*</b>Test Time:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:TextBox ID="TextBox11" runat="server" Width="130px"></asp:TextBox>
                                            <br />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox11" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$" ValidationGroup="ValidationGroup4"></asp:RegularExpressionValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Please enter test time" ControlToValidate="TextBox11" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup4"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                         <td class="td1">
                                            <span class="span1">Remarks:</span>
                                        </td>
                                        <td class="td2">
                                            <asp:TextBox ID="TextBox12" runat="server" Width="200px" TextMode="MultiLine"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <br />
                                            <center>
                                                <asp:Button ID="Button9" runat="server" CssClass="button" Text="Add Test" ValidationGroup="ValidationGroup4" OnClick="Button9_Click" />
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                <asp:Button ID="Button10" runat="server" CssClass="button" Text="Reset" CausesValidation="False" OnClick="Button10_Click" />
                                            </center>
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                                <asp:Panel ID="Panel3" runat="server" Visible="false">
                                    <div id="div4">
                                        <asp:GridView ID="GridView4" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" Width="100%" OnRowDataBound="GridView4_RowDataBound" OnSelectedIndexChanged="GridView4_SelectedIndexChanged">
                                            <Columns>
                                                <asp:BoundField DataField="ID" HeaderText="ID" Visible="false" />
                                                <asp:BoundField DataField="IPD_OBSERVATION_REPORT_ID_FK" HeaderText="Observation No." ItemStyle-Width="10%" />
                                                <asp:BoundField DataField="MEDICAL_TEST" HeaderText="Medical Test" ItemStyle-Width="20%" />
                                                <asp:BoundField DataField="MEDICAL_TEST_DATE" HeaderText="Test Date" ItemStyle-Width="15%" />
                                                <asp:BoundField DataField="MEDICAL_TEST_TIME" HeaderText="Test Time" ItemStyle-Width="13%" />
                                                <asp:BoundField DataField="REMARKS" HeaderText="Remarks" />
                                                <asp:ButtonField HeaderText="Delete" Text="Delete" CommandName="Select" ItemStyle-Width="7%" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </asp:Panel>
                            </fieldset>
                            <br />
                            <br />
                            <center>
                                <asp:Button ID="Button5" runat="server" Text="Submit Observation" CssClass="button" OnClick="Button5_Click" ValidationGroup="ValidationGroup2"></asp:Button>
                            </center>
                            <br />
                            <br />
                        </asp:Panel>
                    </div>
                </div>
            </center>
        </div>
    </form>
</body>
</html>
