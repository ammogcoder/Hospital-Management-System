<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewAllReminders.aspx.cs" Inherits="Receptionist_ReceptionistViewAllReminders" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    input[type=text]{
        border: 1px solid #c4c4c4; 
        height: 20px; 
        width: 275px; 
        font-size: 13px; 
        padding: 4px 4px 4px 4px; 
        border-radius: 4px; 
        -moz-border-radius: 4px; 
        -webkit-border-radius: 4px; 
        box-shadow: 0px 0px 8px #d9d9d9; 
        -moz-box-shadow: 0px 0px 8px #d9d9d9; 
        -webkit-box-shadow: 0px 0px 8px #d9d9d9;
        font-weight:bold;
        font-size:17px;
    }
    input[type=text]:focus {
        outline: none; 
        border: 1px solid #7bc1f7; 
        box-shadow: 0px 0px 8px #7bc1f7; 
        -moz-box-shadow: 0px 0px 8px #7bc1f7; 
        -webkit-box-shadow: 0px 0px 8px #7bc1f7; 
    }
    .button {
        font-family: 'trebuchet ms';
        font-weight: bold;
        color: #FFFFFF !important;
        font-size: 14px;
        text-shadow: 1px 1px 0px #7CACDE;
        box-shadow: 1px 1px 1px #BEE2F9;
        padding: 10px 25px;
        -moz-border-radius: 10px;
        -webkit-border-radius: 10px;
        border-radius: 10px;
        border: 2px solid #3866A3;
        background: #63B8EE;
        background: linear-gradient(top,  #63B8EE,  #468CCF);
        background: -ms-linear-gradient(top,  #63B8EE,  #468CCF);
        background: -webkit-gradient(linear, left top, left bottom, from(#63B8EE), to(#468CCF));
        background: -moz-linear-gradient(top,  #63B8EE,  #468CCF);
    }
    .button:hover {
        color: #14396A !important;
        background: #468CCF;
        background: linear-gradient(top,  #468CCF,  #63B8EE);
        background: -ms-linear-gradient(top,  #468CCF,  #63B8EE);
        background: -webkit-gradient(linear, left top, left bottom, from(#468CCF), to(#63B8EE));
        background: -moz-linear-gradient(top,  #468CCF,  #63B8EE);
    }
    body {
        font-family:'Century Gothic';
        background-color:snow;
    }
    #center1 {
    background-color:lightgoldenrodyellow;
    width:100%;
    border:1px solid;
    }
    .heading {
    font-weight:bold;
    font-size:23pt;
    color:black;
    }
    img {
    width:45px;
    height:45px;
    padding-right:10px;
    }
    legend {
    font-weight:bold;
    margin-left:-400px;
    background-color:lightcoral;
    color:white;
    }
    #div1 {
        background-color:white;
        border:1px solid;
        width:100%;
    }
    fieldset {
        background-color:aliceblue;
        border:1px solid;
        width:60%;
    }
    .span1 {
    font-size:11pt;
    margin-left:40px;
    }
    </style>
    <script type="text/javascript" src="../js/jquery.js"></script>
    <script type="text/javascript" src="../js/Receptionist/ReceptionistViewAllRemindersScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
    <div>
        <center>
            <div>
                <div id="center1">
                    <br />
                    <center>
                        <img src="../images/icon25.png" /><span class="heading">All Reminders</span>
                    </center>
                    <br />
                </div>
                <br />
                <br />
                <div id="div1">
                    <br />
                    <fieldset>
                        <legend>Filter Reminders</legend>
                        <span class="span1"><b style="color:red">*</b>Enter Date:</span>
                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" Format="dd/MM/yyyy"></asp:CalendarExtender>
                        <asp:TextBox ID="TextBox1" runat="server" Width="150"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter date" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter date as dd/mm/yyyy" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/\d{4}"></asp:RegularExpressionValidator>
                        <center>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="1">On Date</asp:ListItem>
                                <asp:ListItem Value="2">Before Date</asp:ListItem>
                                <asp:ListItem Value="3">After Date</asp:ListItem>
                                <asp:ListItem Value="4">All</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please select a filter" ControlToValidate="RadioButtonList1" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            <asp:Button ID="Button1" runat="server" Text="Filter" CssClass="button" OnClick="Button1_Click"></asp:Button>
                        </center>
                    </fieldset>
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" BackColor="Pink" OnClick="LinkButton4_Click">Delete Selected Reminder(s)</asp:LinkButton>
                    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                        <asp:View ID="View1" runat="server">
                             <asp:GridView ID="GridView1" RowStyle-BackColor="OldLace" runat="server"  Width="700px" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" PageSize="5">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
                            <asp:TemplateField HeaderText="Select"><ItemTemplate><asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox></ItemTemplate></asp:TemplateField>
                            <asp:BoundField DataField="REMINDER_TITLE" HeaderText="Title" />
                            <asp:BoundField DataField="REMINDER_DETAILS" HeaderText="Details" />
                            <asp:BoundField DataField="REMINDER_DATE" HeaderText="Date" />
                        </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                        <PagerSettings Mode="NumericFirstLast" />
                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

<RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                        </asp:View>
                         <asp:View ID="View2" runat="server">
                             <asp:GridView ID="GridView2" RowStyle-BackColor="OldLace" runat="server"  Width="700px" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView2_PageIndexChanging" OnRowDataBound="GridView2_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" PageSize="5">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
                            <asp:TemplateField HeaderText="Select"><ItemTemplate><asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox></ItemTemplate></asp:TemplateField>
                            <asp:BoundField DataField="REMINDER_TITLE" HeaderText="Title" />
                            <asp:BoundField DataField="REMINDER_DETAILS" HeaderText="Details" />
                        </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                        <PagerSettings Mode="NumericFirstLast" />
                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

<RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                        </asp:View>
                         <asp:View ID="View3" runat="server">
                             <asp:GridView ID="GridView3" RowStyle-BackColor="OldLace" runat="server"  Width="700px" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView3_PageIndexChanging" OnRowDataBound="GridView3_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" PageSize="5">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" Visible="False" />
                            <asp:TemplateField HeaderText="Select"><ItemTemplate><asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox></ItemTemplate></asp:TemplateField>
                            <asp:BoundField DataField="REMINDER_TITLE" HeaderText="Title" />
                            <asp:BoundField DataField="REMINDER_DETAILS" HeaderText="Details" />
                            <asp:BoundField DataField="REMINDER_DATE" HeaderText="Date" />
                        </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                        <PagerSettings Mode="NumericFirstLast" />
                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

<RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                        </asp:View>
                         <asp:View ID="View4" runat="server">
                             <asp:GridView ID="GridView4" RowStyle-BackColor="OldLace" runat="server"  Width="700px" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="GridView4_PageIndexChanging" OnRowDataBound="GridView4_RowDataBound" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen" RowStyle-HorizontalAlign="Center" PageSize="5">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:TemplateField HeaderText="Select"><ItemTemplate><asp:CheckBox ID="CheckBox1" runat="server"></asp:CheckBox></ItemTemplate></asp:TemplateField>
                            <asp:BoundField DataField="REMINDER_TITLE" HeaderText="Title" />
                            <asp:BoundField DataField="REMINDER_DETAILS" HeaderText="Details" />
                            <asp:BoundField DataField="REMINDER_DATE" HeaderText="Date" />
                        </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

                        <PagerSettings Mode="NumericFirstLast" />
                        <PagerStyle BackColor="#99FF99" BorderColor="#66FFCC" HorizontalAlign="Center" VerticalAlign="Middle" />

<RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                             <br />
                             <br />
                        </asp:View>
                    </asp:MultiView>
                   <br />
                </div>
            </div>
        </center>
    </div>
    </form>
</body>
</html>
