<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistCreatePatientAppointment.aspx.cs" Inherits="Receptionist_ReceptionistSelectPatient" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistCreatePatientAppointmentStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistCreatePatientAppointmentScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
            <div id="center1">
                <br />
                <center>
                    <img src="../images/icon16.png" /><span class="heading">Create Patient Appointment</span>
                </center>
                <br />
            </div> 
            <br />
                    <div id="div1">     
                        <center>  
                                                                         
                            <div>
                            
                                <br />
                                <div>
                                <fieldset id="fieldset1">
                                    <legend id="legend1">Search Patient</legend>
                                    <center>
                                        <table id="table1">
                                            <tr>
                                                <td>
                                                    <span class="span1"><b style="color:red">*</b>Enter Patient Name:</span>
                                                    <br />
                                                    <br />
                                                </td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                                    <br />&nbsp;&nbsp;&nbsp;&nbsp
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
                                        <asp:GridView ID="GridView1" runat="server" RowStyle-BackColor="OldLace" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="700px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
                <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                                            <Columns>
                                                <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
                                                <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" />
                                                <asp:BoundField DataField="PATIENT_PRIMARY_PHONE" HeaderText="Patient Phone No." ItemStyle-Width="150" >
                <ItemStyle Width="150px"></ItemStyle>
                                                </asp:BoundField>
                                                <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" />  
                                            </Columns>

                <HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                <RowStyle HorizontalAlign="Center"></RowStyle>
                                            <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

                <RowStyle HorizontalAlign="Center"></RowStyle>
                                        </asp:GridView>
                                         <b><asp:Label ID="Label1" runat="server" Text="No Patient Found" Visible="false" ForeColor="Red"></asp:Label></b> 
                                    </center>
                                </fieldset> 
                                    <br />   
                            </div>
                        </center>
                        <center>
                            <asp:Panel ID="Panel1" runat="server" Width="600" Visible="False" CssClass="panel1">
                                <br />
                                <br />
                                <fieldset id="fieldset2">
                                    <legend id="legend2">Appointment Details</legend>
                                    <center>
                                        <div>
                                            <table id="table2">
                                                <tr class="tr1">
                                                    <td class="td2">
                                                        <span class="span1">Patient ID:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                                                    </td>
                                                </tr>
                                                <tr class="tr1">
                                                    <td class="td2">
                                                        <span class="span1">Patient Name:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2">
                                                        <asp:MultiView ID="MultiView1" runat="server">
                                                            <asp:View ID="View1" runat="server">
                                                                <center>
                                                                    <b><asp:Label ID="Label3" runat="server" Text="Label" ForeColor="Red"></asp:Label></b>
                                                                </center>
                                                            </asp:View>
                                                            <asp:View ID="View2" runat="server">
                                                                <center>
                                                                    <b><asp:Label ID="Label5" runat="server" Text="Label" BackColor="Yellow"></asp:Label></b>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Print Invoice</asp:LinkButton>
                                                                </center>    
                                                            </asp:View>
                                                        </asp:MultiView>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" class="td2">
                                                        <asp:HyperLink ID="HyperLink2" runat="server"><span class="span1">Appointment History</span></asp:HyperLink>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <span class="span1"><b style="color:red">*</b>Doctor Department:
                                                    </td>
                                                    <td class="td3">
                                                        <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource1" DataTextField="SPECIALITY" DataValueField="ID" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="270"></asp:DropDownList>
                                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [DEPARTMENT_TABLE]"></asp:SqlDataSource>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select doctor department" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <span class="span1"><b style="color:red">*</b>Doctor Name:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <asp:DropDownList ID="DropDownList2" runat="server" Width="200" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
                                                        <asp:Panel ID="Panel2" runat="server" Visible="false">
                                                            <br />
                                                            <asp:HyperLink ID="HyperLink1" runat="server">View Doctor Schedule</asp:HyperLink>
                                                        </asp:Panel>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please select doctor name" ControlToValidate="DropDownList2" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <b style="color:red">*</b>Problem In Body Part:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="BODY_PART" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                                                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [BODY_PART_TABLE]"></asp:SqlDataSource>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please select body part" ControlToValidate="DropDownList3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2" InitialValue="0"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <span class="span1"><b style="color:red">*</b>Problem Description:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
                                                        <br />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please describe the problem" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <span class="span1"><b style="color:red">*</b>Appointment Date:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox2" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                        <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                                                        <br />
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please select appointment date" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="td1">
                                                        <span class="span1"><b style="color:red">*</b>Appointment Time:</span>
                                                    </td>
                                                    <td class="td3">
                                                        <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                                                        <br />
                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please select appointment time" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2">
                                                        <center>
                                                            <div>
                                                                <center>
                                                                    <br />
                                                                    <asp:Button ID="Button2" runat="server" Text="Create Appointment" CssClass="button" OnClick="Button2_Click" ValidationGroup="ValidationGroup2"></asp:Button>
                                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <asp:Button ID="Button3" runat="server" Text="Reset" CssClass="button" CausesValidation="False" OnClick="Button3_Click"></asp:Button>
                                                                </center>
                                                            </div>
                                                        </center>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>    
                                    </center>       
                                </fieldset>
                                <br />
                                <br />
                            </asp:Panel>    
                        </center>
                    </div>
                </center>
            </div>

    </form>
</body>
</html>
