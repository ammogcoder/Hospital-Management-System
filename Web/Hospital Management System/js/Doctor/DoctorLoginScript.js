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