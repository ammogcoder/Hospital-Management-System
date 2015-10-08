<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DoctorHome.aspx.cs" Inherits="Doctor_DoctorHome" MasterPageFile="~/Doctor/DoctorMasterPage.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">
    <link rel="stylesheet" href="../css/Doctor/DoctorHomeStyle.css" />
    <script type="text/javascript" src="../js/jquery.js"></script>

</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="style2" id="div5">
        <center>
            <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="550px" NextPrevFormat="ShortMonth" Width="850px" OnDayRender="Calendar1_DayRender">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#9999FF" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
            </asp:Calendar>   
        </center>     
    </div>
    </asp:Content>
