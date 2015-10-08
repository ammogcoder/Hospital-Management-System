<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorLogin.aspx.cs" Inherits="css_Doctor_DoctorLogin" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hospital Management System</title>

    <link rel="stylesheet" href="../css/Doctor/DoctorLoginStyle.css" />
    <script type="text/javascript" src="../../js/jquery.js"></script>
    <script type="text/javascript" src="../js/Doctor/DoctorLoginScript.js"></script>
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
                            <p id="p1">Doctor Login</p>
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
