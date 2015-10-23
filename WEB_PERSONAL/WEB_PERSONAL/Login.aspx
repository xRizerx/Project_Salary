<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB_PERSONAL.CSS.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 155px;
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">


        .c2 {
            text-align: center;
        }

        .auto-style7 {
            width: 98%;
        }

        .login_pan {
            margin: 0 auto;
            border: 1px solid #c0c0c0;
            padding: 20px;
            text-align: left;
        }

        .bb {
            margin: 0 auto;
            text-align: center;
        }

        .auto-style8 {
            width: 155px;
        }

        .auto-style9 {
            width: 178px;
            height: 29px;
        }

        .auto-style11 {
            width: 178px;
        }
    </style>
    <asp:Panel ID="Panel8" runat="server" Height="328px" CssClass="bb">
        <br />
        <asp:Label ID="Label1" runat="server" Text="เข้าสู่ระบบ" Font-Size="32"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel9" runat="server" Width="345px" CssClass="login_pan">
            <table class="auto-style7">
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style9">
                        <asp:Label ID="Label9" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label7" runat="server" Text="รหัสบัตรประชาชน"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label8" runat="server" Text="รหัสผ่าน"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style11">
             
                        <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click" CssClass="master_default_button">เข้าสู่ระบบ</asp:LinkButton>
               

                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
            </table>

        </asp:Panel>
    </asp:Panel>
</asp:Content>
