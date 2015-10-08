<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistOPDMedicalTest.aspx.cs" Inherits="Receptionist_ReceptionistOPDMedicalTest" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistOPDMedicalTestStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistOPDMedicalTestScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
        <div>
            <div id="center1">
            <br />
            <center>
                <img src="../images/icon20.png" class="img1" /><span class="heading">Schedule Medical Test</span>
            </center>
            <br />
        </div>
        <br />
        <center>
            <div id="div1">
                <br />
                <fieldset id="fieldset2">
                    <legend id="legend1">Search Patient</legend>
                    <br />
                    <br />
                    <table>
                        <tr>
                            <td>
                                <span class="span1"><b style="color:red">*</b>Enter Patient Name:</span>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter patient name" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup1"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter patient name in correct format" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="ValidationGroup1"></asp:RegularExpressionValidator>
                            </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Search" CssClass="button" OnClick="Button1_Click" ValidationGroup="ValidationGroup1"></asp:Button>
                            </td>
                        </tr>
                    </table>                
                <br />
                    <asp:GridView ID="GridView1" RowStyle-BackColor="OldLace" AllowPaging="True" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="90%" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" Visible="False" >
                            <ControlStyle ForeColor="White" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PATIENT_NAME" HeaderText="Patient Name" />
                            <asp:BoundField DataField="PATIENT_PRIMARY_PHONE" HeaderText="Patient Phone No." ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                            </asp:BoundField>
                            <asp:ButtonField HeaderText="Select" Text="Select" CommandName="Select" />  
                        </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                        <PagerSettings Position="Bottom" Mode="NumericFirstLast" />
                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

<RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                </fieldset>
                <br />
                    <b><asp:Label ID="Label1" runat="server" Visible="false"></asp:Label></b>
                    <asp:Panel ID="Panel2" runat="server" Visible="false">
                        <br />
                        <center>
                            <asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click">Print Invoice</asp:LinkButton>
                        </center>
                    </asp:Panel>
                    <asp:Panel ID="Panel1" runat="server" Visible="false">
                        <br />
                         <fieldset id="fieldset1">
                             <legend id="legend2"><b>Medical Test Details</b></legend>
                             <br />
                             <table id="table1">
                                 <tr id="tr1">
                                     <td>
                                         <b>Patient ID:</b>
                                     </td>
                                     <td>
                                         <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                                     </td>
                                 </tr>
                                 <tr id="tr2">
                                     <td>
                                         <b>Patient Name:</b>
                                     </td>
                                     <td>
                                         <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="2">
                                         <center>
                                             <br />
                                             <asp:Accordion ID="Accordion1" runat="server" CssClass="accordion1" HeaderCssClass="accordionheader1" ContentCssClass="accordioncontent1">
                                                 <Panes>
                                                     <asp:AccordionPane ID="AccordionPane1" runat="server">
                                                         <Header><a href="#" class="a1">Health Checkup Packages</a></Header>
                                                         <Content>
                                                             <center>
                                                                 <table>
                                                                     <tr>
                                                                         <td>
                                                                             <img src="../images/master-checkup.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:LinkButton ID="LinkButton1" runat="server" CssClass="linkbutton1">View Details</asp:LinkButton>
                                                                             <br />
                                                                             <asp:RadioButton ID="RadioButton1" runat="server" GroupName="RadioButtonGroup1" OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="true"></asp:RadioButton>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/executive-checkup-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:LinkButton ID="LinkButton2" runat="server" CssClass="linkbutton1">View Details</asp:LinkButton>
                                                                             <br />
                                                                             <asp:RadioButton ID="RadioButton2" runat="server" GroupName="RadioButtonGroup1" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="true"></asp:RadioButton>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/full-body-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:LinkButton ID="LinkButton3" runat="server" CssClass="linkbutton1">View Details</asp:LinkButton>
                                                                             <br />
                                                                             <asp:RadioButton ID="RadioButton3" runat="server" GroupName="RadioButtonGroup1" OnCheckedChanged="RadioButton3_CheckedChanged" AutoPostBack="true"></asp:RadioButton>
                                                                         </td>
                                                                    </tr>
                                                                     <tr>
                                                                         <td>
                                                                             <img src="../images/senior-citizen-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:LinkButton ID="LinkButton4" runat="server" CssClass="linkbutton1">View Details</asp:LinkButton>
                                                                             <br />
                                                                             <asp:RadioButton ID="RadioButton4" runat="server" GroupName="RadioButtonGroup1" OnCheckedChanged="RadioButton4_CheckedChanged" AutoPostBack="true"></asp:RadioButton>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/well-women-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:LinkButton ID="LinkButton5" runat="server" CssClass="linkbutton1">View Details</asp:LinkButton>
                                                                             <br />
                                                                             <asp:RadioButton ID="RadioButton5" runat="server" GroupName="RadioButtonGroup1" OnCheckedChanged="RadioButton5_CheckedChanged" AutoPostBack="true"></asp:RadioButton>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/child-helath-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:LinkButton ID="LinkButton6" runat="server" CssClass="linkbutton1">View Details</asp:LinkButton>
                                                                             <br />
                                                                             <asp:RadioButton ID="RadioButton6" runat="server" GroupName="RadioButtonGroup1" OnCheckedChanged="RadioButton6_CheckedChanged" AutoPostBack="true"></asp:RadioButton>
                                                                         </td>
                                                                     </tr>
                                                                 </table>
                                                             </center>
                                                         </Content>
                                                     </asp:AccordionPane>
                                                     <asp:AccordionPane ID="AccordionPane2" runat="server">
                                                         <Header><a href="#" class="a1">Checkup By Disorder</a></Header>
                                                         <Content>
                                                             <center>
                                                                 <table>
                                                                     <tr>
                                                                         <td>
                                                                             <img src="../images/Cardiac-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Diabetes-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Gastro-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Neuro-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox4" runat="server" OnCheckedChanged="CheckBox4_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Liver-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox5" runat="server" OnCheckedChanged="CheckBox5_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                    </tr>
                                                                    <tr>
                                                                         <td>
                                                                             <img src="../images/Ortho-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox6" runat="server" OnCheckedChanged="CheckBox6_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Cancer--img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox7" runat="server" OnCheckedChanged="CheckBox7_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Renal--img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox8" runat="server" OnCheckedChanged="CheckBox8_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                         <td>
                                                                             <img src="../images/Uro-img.jpg" />
                                                                             <br />
                                                                             <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                                                                             <br />
                                                                             <asp:CheckBox ID="CheckBox9" runat="server" OnCheckedChanged="CheckBox9_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                         </td>
                                                                     </tr>
                                                                 </table>
                                                              </center>
                                                         </Content>
                                                     </asp:AccordionPane>
                                                     <asp:AccordionPane ID="AccordionPane4" runat="server">
                                                         <Header><a href="#" class="a1">Checkup By Disorder</a></Header>
                                                         <Content>
                                                             <center>
                                                                 <table style="overflow:hidden;">                                                                  
                                                                        <tr>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label20" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox10" runat="server" OnCheckedChanged="CheckBox10_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label21" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox11" runat="server" OnCheckedChanged="CheckBox11_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label22" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox12" runat="server" OnCheckedChanged="CheckBox12_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label23" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label35" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox13" runat="server" OnCheckedChanged="CheckBox13_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label24" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label36" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox14" runat="server" OnCheckedChanged="CheckBox14_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label25" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label37" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox15" runat="server" OnCheckedChanged="CheckBox15_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label26" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox16" runat="server" OnCheckedChanged="CheckBox16_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label27" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox17" runat="server" OnCheckedChanged="CheckBox17_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label28" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox18" runat="server" OnCheckedChanged="CheckBox18_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label29" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox19" runat="server" OnCheckedChanged="CheckBox19_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label30" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox20" runat="server" OnCheckedChanged="CheckBox20_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                            <td>
                                                                                <div class="div1">
                                                                                    <asp:Label ID="Label31" runat="server" Text="Label" CssClass="label1"></asp:Label>
                                                                                    <br />
                                                                                    <asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>
                                                                                    <br />
                                                                                    <asp:CheckBox ID="CheckBox21" runat="server" OnCheckedChanged="CheckBox21_CheckedChanged" AutoPostBack="true"></asp:CheckBox>
                                                                                </div>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                              </center>
                                                         </Content>
                                                     </asp:AccordionPane>
                                                 </Panes>
                                             </asp:Accordion>
                                         </center>
                                     </td>
                                 </tr>
                                 <tr>
                                     <br />
                                     <td>
                                         <br />
                                         <span class="span1" style="margin-left:180px"><b style="color:red">*</b>Test Date:</span>
                                     </td>
                                     <td>
                                         <br />
                                         <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox2" Format="dd/MM/yyyy"></asp:CalendarExtender>
                                         <asp:TextBox ID="TextBox2" runat="server" Width="200px" CssClass="textbox1"></asp:TextBox>
                                         <br />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ValidationGroup="ValidationGroup2" ErrorMessage="Please enter date of birth" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}" ValidationGroup="ValidationGroup2"></asp:RegularExpressionValidator>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <br />
                                         <span class="span1" style="margin-left:180px"><b style="color:red">*</b>Test Time:</span>
                                     </td>
                                     <td>
                                         <br />
                                         <asp:TextBox ID="TextBox3" runat="server" Width="200px" CssClass="textbox1"></asp:TextBox>
                                         <br />
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please select time of admit" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationGroup="ValidationGroup2"></asp:RequiredFieldValidator>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td>
                                         <span class="span1" style="margin-left:180px">Grand Total:</span>
                                     </td>
                                     <td>
                                         <b><asp:Label ID="Label2" runat="server" Text="0" CssClass="textbox1"></asp:Label></b>
                                     </td>
                                 </tr>
                                 <tr>
                                     <td colspan="2">
                                         <br />
                                         <center>
                                             <asp:Button ID="Button2" runat="server" Text="Create Test" CssClass="button" OnClick="Button2_Click" ValidationGroup="ValidationGroup2" CausesValidation="False"></asp:Button>
                                             &nbsp;&nbsp;&nbsp;&nbsp;
                                             <asp:Button ID="Button3" runat="server" Text="Reset" CssClass="button" CausesValidation="False" ValidationGroup="ValidationGroup2" OnClick="Button3_Click"></asp:Button>
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
                <asp:PostBackTrigger ControlID="Button2" />
                <asp:PostBackTrigger ControlID="LinkButton7" />
            </Triggers>
        </asp:UpdatePanel>
    </form>
</body>
</html>
