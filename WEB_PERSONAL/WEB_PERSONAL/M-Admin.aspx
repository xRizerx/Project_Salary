<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="M-Admin.aspx.cs" Inherits="WEB_PERSONAL.M_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 150px;
            text-align:right;
        }
        .wrapper {
            background-color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center><img class="irc_mi" style="margin-top: 33px;" src="http://202.143.129.110/assessment/images/Admin_Womenfund.jpg" width="304" height="328"></center>
    </div>
    <div>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label8" runat="server" Text="ข้อเสนอแนะ"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="150px" TextMode="MultiLine" Width="750px" CssClass="master_default_textbox_multi_line"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:LinkButton ID="LinkButton13" runat="server" CssClass="master_default_button" OnClick="LinkButton13_Click">ส่ง</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    
</asp:Content>
