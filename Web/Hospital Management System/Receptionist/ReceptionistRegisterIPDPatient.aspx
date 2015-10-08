<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistRegisterIPDPatient.aspx.cs" Inherits="Receptionist_ReceptionistSelectPatientForIPD" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistRegisterIPDPatientStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistRegisterIPDPatientScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="center1">
                    <br />
                        <center>
                        <img src="../images/icon2.png" /><span class="heading">Register IPD Patient</span>
                    </center>
                    <br />
                </div>
                <br />
                <div id="div1">                   
                <br />
                <center>
                    <div>
                        <center>
                            <fieldset id="fieldset1">
                            <legend id="legend1">Search Patient</legend>           
                            <br />
                            <table>
                                <tr>
                                    <td class="td1">
                                        <span class="span2"><b style="color:red">*</b>Enter Patient Name:</span>
                                        <br />
                                        <br />
                                    </td>
                                    <td class="td1">
                                        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="ValidationGroup1" Width="200px"></asp:TextBox>
                                        <br />                                        
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter patient name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter patient name in correct format" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="ValidationGroup1"></asp:RegularExpressionValidator>
                                        <br />
                                    </td>
                                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" OnClick="Button1_Click" ValidationGroup="ValidationGroup1"></asp:Button>
                                        <br />
                                        <br />
                                    </td>
                                </tr>
                            </table>
                            <asp:GridView ID="GridView1" RowStyle-BackColor="OldLace" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="550px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
    <AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                                <Columns>
                                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" >
                                    <ControlStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" ItemStyle-Width="200px" />
                                    <asp:BoundField DataField="PATIENT_PRIMARY_PHONE" HeaderText="Patient Phone No." ItemStyle-Width="150px" >
    <ItemStyle Width="150px"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" ItemStyle-Width="100px" />  
                                </Columns>

    <HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                                <PagerSettings Position="Bottom" Mode="NumericFirstLast" />
                                <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

    <RowStyle HorizontalAlign="Center"></RowStyle>
                            </asp:GridView>
                            <b><asp:Label ID="Label1" runat="server" Text="No Patient Found" Visible="false" ForeColor="Red"></asp:Label></b>
                            <br />
                        </fieldset>
                        <br />
                        </center>
                        <asp:Panel ID="Panel3" runat="server" Width="700" CssClass="panel1" Visible="false">
                            <br />
                            <br />
                                <fieldset id="fieldset2">
                                    <legend id="legend2">IPD Patient Details</legend>
                                    <asp:Panel ID="Panel2" runat="server" Visible="false">
                                        <br />
                                        <b><asp:Label ID="Label3" runat="server" Text="Patient Admitted" BackColor="Yellow"></asp:Label></b>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Print Report</asp:LinkButton>
                                        <br />
                                        <br />
                                    </asp:Panel>
                            
                                    <table id="table3">
                                        <tr style="background-color:lightgreen">
                                            <td>
                                                Patient ID:
                                            </td>
                                            <td>
                                                <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                                            </td>
                                        </tr>
                                        <tr style="background-color:lightgreen">
                                            <td>
                                                Patient Name:
                                            </td>
                                            <td>
                                                <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                                            </td>
                                        </tr>
                                    </table>
                                    <table id="table1">
                                        <tr>
                                            <td class="td2">
                                                <span class="span1"><b style="color:red">*</b>Patient general health:</span>
                                            </td>
                                            <td>
                                                <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal" DataSourceID="SqlDataSource1" DataTextField="PATIENT_GENERAL_HEALTH" DataValueField="ID">
                                                </asp:RadioButtonList>
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [PATIENT_GENERAL_HEALTH]"></asp:SqlDataSource>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select general health" ControlToValidate="RadioButtonList2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>Regular Medications:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Allergy Status:</span>
                                                <br />
                                            </td>
                                            <td>
                                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                                                    <asp:ListItem Value="1">Yes</asp:ListItem>
                                                    <asp:ListItem Value="0">No</asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please select allergy status" ControlToValidate="RadioButtonList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>Allergies:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                <br />
                                                <asp:CustomValidator ID="CustomValidator5" runat="server" ErrorMessage="Please enter allergies" ClientValidationFunction="clientRequiredFieldCustomValidator3" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" OnServerValidate="CustomValidator5_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True" ValidationGroup="ValidationGroup2"></asp:CustomValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Major Surgeries Status:</span>
                                            </td>
                                            <td>
                                                <asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList5_SelectedIndexChanged">
                                                    <asp:ListItem Value="1">Yes</asp:ListItem>
                                                    <asp:ListItem Value="0">No</asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please select major surgeries status" ControlToValidate="RadioButtonList5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1">Type and Date of Surgery:</span>
                                            </td>
                                            <td>
                                                <table>
                                                    <tr>
                                                        <td>
                                                            <span class="span1"><asp:Label ID="Label7" runat="server" Text="*" ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>Surgery</span>
                                                        </td>
                                                        <td>
                                                            <span class="span1"><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>When</span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox4" runat="server" Width="150" CausesValidation="True"></asp:TextBox>
                                                            <br />
                                                            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox4" SetFocusOnError="true" ForeColor="Red" Display="Dynamic" ErrorMessage="Please enter surgery name" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="ValidationGroup2" ValidateEmptyText="True" ClientValidationFunction="clientRequiredFieldCustomValidator1"></asp:CustomValidator>
                                                        </td>
                                                        <td>
                                                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox5" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:TextBox ID="TextBox5" runat="server" Width="100" CausesValidation="True"></asp:TextBox>
                                                            <br />
                                                            <asp:CustomValidator ID="CustomValidator2" runat="server" OnServerValidate="CustomValidator2_ServerValidate" ControlToValidate="TextBox5" SetFocusOnError="true" ForeColor="Red" Display="Dynamic" ErrorMessage="Please enter surgery date" ValidationGroup="ValidationGroup2" ClientValidationFunction="clientRequiredFieldCustomValidator1" ValidateEmptyText="True"></asp:CustomValidator>
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                        <tr>
                                                        <td>
                                                            <span class="span1">Surgery</span>
                                                        </td>
                                                        <td>
                                                            <span class="span1">When</span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox6" runat="server" Width="150"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox7" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:TextBox ID="TextBox7" runat="server" Width="100"></asp:TextBox>
                                                            <br />
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <span class="span1">Surgery</span>
                                                        </td>
                                                        <td>
                                                            <span class="span1">When</span>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:TextBox ID="TextBox8" runat="server" Width="150"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            <asp:CalendarExtender ID="CalendarExtender3" runat="server" TargetControlID="TextBox9" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                            <asp:TextBox ID="TextBox9" runat="server" Width="100"></asp:TextBox>
                                                            <br />
                                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox9" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Medical Insurance Status:</span>
                                            </td>
                                            <td>
                                                <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged">
                                                    <asp:ListItem Value="1">Yes</asp:ListItem>
                                                    <asp:ListItem Value="0">No</asp:ListItem>
                                                </asp:RadioButtonList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please select medical insurance status" ControlToValidate="RadioButtonList3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><asp:Label ID="Label9" runat="server" Text="*" ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>Insurance Provider:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox15" runat="server" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Please enter insurance provider name" ClientValidationFunction="clientRequiredFieldCustomValidator2" ControlToValidate="TextBox15" Display="Dynamic" ForeColor="Red" OnServerValidate="CustomValidator3_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True" ValidationGroup="ValidationGroup2"></asp:CustomValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please enter provider name in correct format" ControlToValidate="TextBox15" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><asp:Label ID="Label10" runat="server" Text="*" ForeColor="Red" Font-Bold="true" Visible="false"></asp:Label>Policy Number:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox16" runat="server" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:CustomValidator ID="CustomValidator4" runat="server" ErrorMessage="Please enter policy number" ClientValidationFunction="clientRequiredFieldCustomValidator2" ControlToValidate="TextBox15" Display="Dynamic" ForeColor="Red" OnServerValidate="CustomValidator4_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True" ValidationGroup="ValidationGroup2"></asp:CustomValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Patient Height (ft.):</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox10" runat="server" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please enter patient height" ControlToValidate="TextBox10" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Patient Weight (kg):</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox11" runat="server" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Please enter patient weight" ControlToValidate="TextBox10" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Blood Group:</span>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList1" runat="server">
                                                    <asp:ListItem>--Select--</asp:ListItem>
                                                    <asp:ListItem>A+</asp:ListItem>
                                                    <asp:ListItem>A-</asp:ListItem>
                                                    <asp:ListItem>B+</asp:ListItem>
                                                    <asp:ListItem>B-</asp:ListItem>
                                                    <asp:ListItem>AB+</asp:ListItem>
                                                    <asp:ListItem>AB-</asp:ListItem>
                                                    <asp:ListItem>O+</asp:ListItem>
                                                    <asp:ListItem>O-</asp:ListItem>
                                                </asp:DropDownList>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please select blood group" ControlToValidate="DropDownList3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td><span class="span1"><b style="color:red">*</b>Attending Doctor:</span> </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList2" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource3" DataTextField="DOCTOR_NAME" DataValueField="ID">
                                                </asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT B.ID, (A.EMPLOYEE_FIRST_NAME + ' ' + ISNULL(A.EMPLOYEE_MIDDLE_NAME, '') + ' ' + ISNULL(A.EMPLOYEE_LAST_NAME, '')) AS DOCTOR_NAME
                        FROM [HMS].[dbo].[EMPLOYEE_MASTER_TABLE] A, [HMS].[dbo].[DOCTOR_MASTER_TABLE] B
                        WHERE A.ID=B.EMPLOYEE_ID_FK;"></asp:SqlDataSource>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="DropDownList2" Display="Dynamic" ErrorMessage="Please select attending doctor" ForeColor="Red" InitialValue="0" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Admission Ward:</span>
                                            </td>
                                            <td>

                                                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="WARD_NAME" DataValueField="ID" AppendDataBoundItems="True" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" ClientIDMode="Inherit"></asp:DropDownList>
                                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [WARD_TABLE]"></asp:SqlDataSource>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Please select admission ward" ControlToValidate="DropDownList3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Available Ward Numbers:</span>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="DropDownList5" runat="server" AppendDataBoundItems="True"></asp:DropDownList>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Please select ward number" ControlToValidate="RadioButtonList5" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" InitialValue="0" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Date Of Admit:</span>
                                            </td>
                                            <td>
                                                <asp:CalendarExtender ID="CalendarExtender5" runat="server" TargetControlID="TextBox18" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                                <asp:TextBox ID="TextBox18" runat="server" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please enter date of admit" ControlToValidate="TextBox18" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox18" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1"><b style="color:red">*</b>Time Of Admit:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox19" runat="server" Width="200px"></asp:TextBox>
                                                <br />
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ErrorMessage="Please enter time in correct format" ControlToValidate="TextBox9" Display="Dynamic" ForeColor="Red" ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]\040(AM|am|PM|pm)$" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please enter time of admit" ControlToValidate="TextBox19" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <span class="span1">Remark:</span>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="TextBox17" runat="server" TextMode="MultiLine"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <br />
                                                <center>
                                                    <asp:Button ID="Button2" runat="server" Text="Register IPD Patient" CssClass="button" OnClick="Button2_Click" ValidationGroup="ValidationGroup2"></asp:Button>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <asp:Button ID="Button3" runat="server" Text="Reset" CssClass="button" CausesValidation="False" OnClick="Button3_Click"></asp:Button>
                                                </center>
                                            </td>
                                        </tr>
                                    </table>
                                </fieldset>
                            </asp:Panel>
            </div>
        </center>
        </div>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="LinkButton1" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
