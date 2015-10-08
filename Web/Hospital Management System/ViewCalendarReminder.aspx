<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewCalendarReminder.aspx.cs" Inherits="Receptionist_ReceptionistViewCalendarReminder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
    font-family:'Century Gothic';
    background-color:snow;
}
#table1 {
    margin: 10px auto;
    width:650px;
    background-color:lightgrey;
    border-radius:0.5em;
}
.label {
    font-size:25px;
    font-weight:700;
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
#center1 {
    background-color:lightgoldenrodyellow;
    width:100%;
    border:1px solid;
}
.heading {
    font-weight:bold;
    font-size:20pt;
    color:black;
}
#div1 {
    background-color:aliceblue;
    width:100%;
    border:1px solid;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <div>
                <div id="center1">
                    <br />
                    <center>
                        <span class="heading">Reminders on <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span>
                    </center>
                    <br />                   
                </div>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Reminder Deleted" Font-Bold="true" BackColor="Yellow" Visible="false"></asp:Label>
                <br />
                <div id="div1">
                    <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AlternatingRowStyle-BackColor="Wheat" HeaderStyle-BackColor="YellowGreen"  Width="95%" RowStyle-HorizontalAlign="Center" SelectedIndex="0" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
<AlternatingRowStyle BackColor="Wheat"></AlternatingRowStyle>
                        <Columns>
                            <asp:BoundField HeaderText="ID" DataField="ID" ReadOnly="true" Visible="False" />
                            <asp:BoundField HeaderText="Title" DataField="REMINDER_TITLE" />
                            <asp:BoundField HeaderText="Details" DataField="REMINDER_DETAILS" />
                            <asp:ButtonField HeaderText="Delete" Text="Delete" CommandName="Select" />
                        </Columns>

<HeaderStyle BackColor="YellowGreen"></HeaderStyle>

<RowStyle HorizontalAlign="Center"></RowStyle>
                    </asp:GridView>
                    <br />
                </div>
            </div>
        </center>
    </div>
    </form>
</body>
</html>
