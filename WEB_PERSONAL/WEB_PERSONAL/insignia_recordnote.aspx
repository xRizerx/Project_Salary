<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_recordnote.aspx.cs" Inherits="WEB_PERSONAL.insignis_recordnote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 90px;
        }
        .auto-style4 {
            width: 100px;
        }
    </style>
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
                    <td colspan="2">เหรียญตราฯ</td>
                </tr>
                <tr align="center">
                    <td></td>
                    <td class="auto-style3">เล่ม</td>
                    <td class="auto-style3">ตอน</td>
                    <td>หน้า</td>
                    <td class="auto-style4">วัด เดือน ปี</td>
                    <td class="auto-style3">ได้รับ</td>
                    <td class="auto-style3">ไม่ได้รับ</td>
                    <td>ได้รับ</td>
                    <td>ไม่ได้รับ</td>
                </tr>
                 <tr align="center">
                    <td></td>
                    <td class="auto-style3"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td class="auto-style3"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td class="auto-style4"><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    <td class="auto-style3"><asp:RadioButton ID="RadioButton1" runat="server" groupname="G1"/></td>
                    <td class="auto-style3"><asp:RadioButton ID="RadioButton2" runat="server" groupname="G1"/></td>
                    <td><asp:RadioButton ID="RadioButton3" runat="server" groupname="G2"/></td>
                    <td><asp:RadioButton ID="RadioButton4" runat="server" groupname="G2"/></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </div>
    </asp:Panel>
</asp:Content>
