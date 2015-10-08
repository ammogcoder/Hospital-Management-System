<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReceptionistPatientDetails.aspx.cs" Inherits="Receptionist_ReceptionistPatientDetails" MasterPageFile="~/Receptionist/ReceptionistMasterPage.master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">
    
    <link rel="stylesheet" href="../css/Receptionist/ReceptionistPatientDetailsStyle.css" />
</asp:Content>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div class="style2" id="div5">
        <table id="table1">
             <tr>
                <td colspan="2">
                    <img src="../images/icon18.png" height="50" width="50" />&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Patient Details" CssClass="label"></asp:Label>
                    <hr />
                </td>
            </tr>
        </table>
        <asp:TabContainer ID="TabContainer1" runat="server" Width="850px">
            <asp:TabPanel ID="TabPanel1" runat="server" HeaderText="Registration Details">
                <ContentTemplate>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                           <table id="table2">
                                <tr>
                                    <td>
                                        Patient ID:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Name Prefix:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient First Name:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Last Name:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Date Of Birth:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Marital Status:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Gender:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Street Address:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient City:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Zip Code:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient State:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Country:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Primary Phone Number:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label14" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Secondary Phone Number:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label15" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Emergency Contact Name:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label16" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Emergency Contact Phone Number:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label17" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>            
                                <tr>
                                    <td>
                                        Patient Email Address:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label18" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Occupation Type:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label19" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Employer Name:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label20" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Employer Street Address:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label21" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Employer City:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label22" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Employer State:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label23" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Country:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label24" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Primary Language:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label25" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Reference:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label27" runat="server" Text="Label"></asp:Label></b>            
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Reference Source:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label26" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Family Size:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label28" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Monthly Income:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label29" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Registration Date:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label30" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel ID="TabPanel2" runat="server" HeaderText="Medical Information">
                <ContentTemplate>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <table id="table3">
                                <tr>
                                    <td>
                                        Patient ID:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label31" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient General Health:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label32" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Regular Medications:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label33" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Allergies:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label34" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Surgery 1:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label35" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Surgery 1 Date:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label36" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Surgery 2:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label37" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Surgery 2 Date:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label38" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Surgery 3:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label39" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Surgery 3 Date:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label40" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Provider:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label41" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Policy Number:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label42" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Subscriber Relationship:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label43" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Subscriber Relationship (Other):
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label44" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Subscriber Name Prefix:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label45" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Subscriber First Name:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label46" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>            
                                <tr>
                                    <td>
                                        Patient Medical Insurance Subscriber Last Name:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label47" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Medical Insurance Subscriber DOB:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label48" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Height:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label49" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Weight:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label50" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Attending Doctor:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label51" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Ward:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label52" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Ward Number:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label53" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Date Of Admit:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label54" runat="server" Text="Label"></asp:Label></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        Patient Remark:
                                    </td>
                                    <td>
                                        <b><asp:Label ID="Label55" runat="server" Text="Label"></asp:Label></b>            
                                    </td>
                                </tr>
                            </table>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
</asp:Content>
