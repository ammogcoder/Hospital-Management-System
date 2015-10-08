<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HRAddDoctor.aspx.cs" Inherits="HR_HRRegisterPersonnelDoctor" MasterPageFile="~/HR/HRDoctorMasterPage.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">

    <link rel="stylesheet" href="../css/HR/HRAddDoctorStyle.css" />
    <link rel="stylesheet" href="../css/jquery.timepicker.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/jquery-ui.js"></script>
    <script type="text/javascript" src="../js/jquery.timepicker.js"></script>
    <script type="text/javascript">
        $(document).ready(function (e) {
            $("#<%=TextBox20.ClientID%>").timepicker();
            $("#<%=TextBox21.ClientID%>").timepicker();
            $("#<%=TextBox22.ClientID%>").timepicker();
            $("#<%=TextBox23.ClientID%>").timepicker();
            $("#<%=TextBox24.ClientID%>").timepicker();
            $("#<%=TextBox25.ClientID%>").timepicker();
            $("#<%=TextBox26.ClientID%>").timepicker();
            $("#<%=TextBox27.ClientID%>").timepicker();
            $("#<%=TextBox28.ClientID%>").timepicker();
            $("#<%=TextBox29.ClientID%>").timepicker();
            $("#<%=TextBox30.ClientID%>").timepicker();
            $("#<%=TextBox31.ClientID%>").timepicker();
            $("#<%=TextBox32.ClientID%>").timepicker();
            $("#<%=TextBox33.ClientID%>").timepicker();
            $("#<%=TextBox34.ClientID%>").timepicker();
            $("#<%=TextBox35.ClientID%>").timepicker();
            $("#<%=TextBox36.ClientID%>").timepicker();
            $("#<%=TextBox37.ClientID%>").timepicker();
            $("#<%=TextBox38.ClientID%>").timepicker();
            $("#<%=TextBox39.ClientID%>").timepicker();
            $("#<%=TextBox40.ClientID%>").timepicker();
            $("#<%=TextBox42.ClientID%>").timepicker();
            $("#<%=TextBox43.ClientID%>").timepicker();
            $("#<%=TextBox44.ClientID%>").timepicker();
            $("#<%=TextBox45.ClientID%>").timepicker();
            $("#<%=TextBox46.ClientID%>").timepicker();
            $("#<%=TextBox47.ClientID%>").timepicker();
            $("#<%=TextBox48.ClientID%>").timepicker();
            $("#<%=TextBox49.ClientID%>").timepicker();
            $("#<%=TextBox50.ClientID%>").timepicker();
            $("#<%=TextBox51.ClientID%>").timepicker();
            $("#<%=TextBox52.ClientID%>").timepicker();
            $("#<%=TextBox53.ClientID%>").timepicker();
            $("#<%=TextBox54.ClientID%>").timepicker();
            $("#<%=TextBox55.ClientID%>").timepicker();
            $("#<%=TextBox56.ClientID%>").timepicker();
            $("#<%=TextBox57.ClientID%>").timepicker();
            $("#<%=TextBox58.ClientID%>").timepicker();
            $("#<%=TextBox59.ClientID%>").timepicker();
            $("#<%=TextBox60.ClientID%>").timepicker();
            $("#<%=TextBox61.ClientID%>").timepicker();
            $("#<%=TextBox62.ClientID%>").timepicker();
        });
    </script>
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="style2" id="div5">
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="1">
            <asp:View ID="View1" runat="server">
                <table class="table">
                    <tr>
                        <td colspan="4">
                            <center>
                                <img src="../images/icon23.png" height="40" width="40" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Add Doctor" CssClass="label"></asp:Label>
                                <hr />
                                <br />
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>Doctor Name:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Width="200"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter last name" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>               
                        <td>
                            <b>Gender:</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem Value="0">--Select--</asp:ListItem>
                                <asp:ListItem Value="M">Male</asp:ListItem>
                                <asp:ListItem Value="F">Female</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>Date Of Birth:</b>
                        </td>
                        <td>
                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox3"></asp:CalendarExtender>
                            <asp:TextBox ID="TextBox3" runat="server" Width="200"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter date of birth" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <b>Address:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" TextMode="MultiLine" Width="200"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter street address" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>Phone Number:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox7" runat="server" Width="200" onkeypress="return isNumberKey(event)"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Please enter primary phone number" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <b>Email Address:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox9" runat="server" Width="200"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>License Number:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox12" runat="server" Width="200"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Please enter license number" ControlToValidate="TextBox12" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <b>Speciality Field:</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="SPECIALITY" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [DEPARTMENT_TABLE]"></asp:SqlDataSource>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Please select speciality field" ControlToValidate="DropDownList3" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>Medical Experience:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox13" runat="server" Width="200" onkeypress="return isNumberKey(event)"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Please enter medical experience" ControlToValidate="TextBox13" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <b>Medical Degree:</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource3" DataTextField="MEDICAL_DEGREE" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [MEDICAL_DEGREE_TABLE]"></asp:SqlDataSource>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ErrorMessage="Please select medical degree" ControlToValidate="DropDownList4" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>Bank:</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource5" DataTextField="BANK_NAME" DataValueField="ID" AppendDataBoundItems="True"></asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="Provider=SQLNCLI11;Data Source=JARVIS;Integrated Security=SSPI;Initial Catalog=HMS" ProviderName="System.Data.OleDb" SelectCommand="SELECT * FROM [BANK_NAME_TABLE]"></asp:SqlDataSource>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ErrorMessage="Please select bank" ControlToValidate="DropDownList5" Display="Dynamic" ForeColor="Red" InitialValue="0" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <b>Bank Account Number:</b>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox19" runat="server" Width="200" onkeypress="return isNumberKey(event)"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ErrorMessage="Please enter bank account number" ControlToValidate="TextBox19" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <b>Date of Joining:</b>
                        </td>
                        <td>
                            <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="TextBox18"></asp:CalendarExtender>
                            <asp:TextBox ID="TextBox18" runat="server" Width="200"></asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="Please enter date of joining" ControlToValidate="TextBox18" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>    
                        <td colspan="4">
                        <center>
                            <div id="div6">
                                <asp:Button ID="Button1" runat="server" Text="Register" CssClass="button" OnClick="Button1_Click" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="Reset" CssClass="button" />
                            </div>
                        </center>
                    </td>
                </tr>
                <tr><td></td><td></td><td></td><td></td></tr>
                </table>            
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table id="table2">
                    <tr>
                        <td colspan="4">
                            <center>
                                <img src="../images/icon16.png" height="40" width="40" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Doctor Schedule" CssClass="label"></asp:Label>
                                <hr />
                                <br />
                            </center>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <table id="table3" border="1">
                                <tr>
                                    <td>
                                        <center><b>Day</b></center>
                                    </td>
                                    <td>
                                        <b>
                                            <center>Session 1<br />From</center>
                                        </b>
                                    </td>
                                    <td>
                                        <b>
                                            <center>Session 1<br />To</center>
                                        </b>
                                    </td>
                                    <td>
                                        <b>
                                            <center>Session 2<br />From</center>
                                        </b>
                                    </td>
                                    <td>
                                        <b>
                                            <center>Session 2<br />To</center>
                                        </b>
                                    </td>
                                    <td>
                                        <b>
                                            <center>Session 3<br />From</center>
                                        </b>
                                    </td>
                                    <td>
                                        <b>
                                            <center>Session 3<br />To</center>
                                        </b>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>MONDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox20" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox21" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox22" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox23" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox24" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox25" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>TUESDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox26" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox27" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox28" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox29" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox30" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox31" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>WEDNESDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox32" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox33" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox34" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox35" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox36" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox37" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>THURSDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox38" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox39" runat="server" Width="100"></asp:TextBox> 
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox40" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox42" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox43" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox44" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>FRIDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox45" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox46" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox47" runat="server" Width="100"></asp:TextBox>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox48" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox49" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox50" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>SATURDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox51" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox52" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox53" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox54" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox55" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox56" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-color:lightgoldenrodyellow"><center>SUNDAY</center></td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox57" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue" >
                                        <center>
                                            <asp:TextBox ID="TextBox58" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox59" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox60" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox61" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                    <td style="background-color:lightsteelblue">
                                        <center>
                                            <asp:TextBox ID="TextBox62" runat="server" Width="100"></asp:TextBox>
                                        </center>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <center>
                                <asp:Button ID="Button3" runat="server" Text="Set Schedule" CssClass="button" OnClick="Button3_Click"></asp:Button>
                            </center>
                        </td>
                    </tr>
                    <tr><td></td></tr>
                </table>
            </asp:View>
        </asp:MultiView>
        
    </div>
</asp:Content>