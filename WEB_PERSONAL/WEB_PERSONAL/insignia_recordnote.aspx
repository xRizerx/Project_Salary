<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote.aspx.cs" Inherits="WEB_PERSONAL.insignis_recordnote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel8" runat="server" Height="1094px">
        <div>
            <table border="1">
                <tr align="center">
                    <td>
                        ได้รับชั้น / รายการ
                    </td>
                    <td colspan="4">
                        ราชกิจจานุเบกษา
                    </td>
                    <td colspan="2">ใบกำกับ</td>
                </tr>
                <tr align="center">
                    <td></td>
                    <td>เล่ม</td>
                    <td>ตอน</td>
                    <td>หน้า</td>
                    <td>วัด เดือน ปี</td>
                    <td>ได้รับ</td>
                    <td>ไม่ได้รับ</td>
                </tr>
                 <tr align="center">
                    <td></td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    <td><asp:RadioButton ID="RadioButton1" runat="server" groupname="asd"/></td>
                    <td><asp:RadioButton ID="RadioButton2" runat="server" groupname="asd"/></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </div>
    </asp:Panel>
</asp:Content>
