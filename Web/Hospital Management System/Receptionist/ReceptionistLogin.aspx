<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistLogin.aspx.cs" Inherits="css_Receptionist_ReceptionistLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hospital Management System</title>

    <link rel="stylesheet" href="../css/Receptionist/ReceptionistLoginStyle.css" />
    <script type="text/javascript" src="../../js/jquery.js"></script>
    <script type="text/javascript">
        $(document).ready(function (e) {
            $("#<%=Button1.ClientID%>").click(function (e) {
                var username = $("#<%=TextBox1.ClientID%>").val();
                var password = $("#<%=TextBox2.ClientID%>").val();
                if (username == "" && password != "") {
                    $("#<%=TextBox1.ClientID%>").css("background-color", "pink");
                    $("#<%=TextBox2.ClientID%>").css("background-color", "white");
                    $("#<%=TextBox1.ClientID%>").focus();
                    alert("Please Enter Username");
                    e.preventDefault();
                }
                else if (password == "" && username != "") {
                    $("#<%=TextBox2.ClientID%>").css("background-color", "pink");
                    $("#<%=TextBox1.ClientID%>").css("background-color", "white");
                    $("#<%=TextBox2.ClientID%>").focus();
                    alert("Please Enter Password");
                    e.preventDefault();
                }
                else if (username == "" && password == "") {
                    $("#<%=TextBox1.ClientID%>").css("background-color", "pink");
                    $("#<%=TextBox2.ClientID%>").css("background-color", "pink");
                    $("#<%=TextBox1.ClientID%>").focus();
                    alert("Please Enter Username & Password");
                    e.preventDefault();
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <img id="img1" src="../../images/hospitalmanagement.jpg" />
        </div>
        <div id="content">
            <center>
                <div id="div1">
                    <div id="div2">
                        <center>
                            <br />
                            <p id="p1">Receptionist Login</p>
                        </center>
                        <hr />
                    </div>
                    <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter Username"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Login" CssClass="button" OnClick="Button1_Click"></asp:Button>
                </div>
            </center>
        </div>
    </form>
</body>
</html>
