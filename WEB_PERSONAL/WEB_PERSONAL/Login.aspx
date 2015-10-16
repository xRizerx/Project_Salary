<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB_PERSONAL.CSS.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 187px;
        }

        .auto-style5 {
            width: 187px;
            height: 53px;
        }

        .auto-style6 {
            height: 53px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .login_button_div ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            margin-top: 8px;
        }

        .login_button_div li {
            display: inline;
            /*555*/
        }

        .login_button_div a {
            text-decoration: none;
            display: inline;
            padding: 5px 20px;
            margin: 0;
            width: 60px;
            color: #c0c0c0;
            background-color: #000000;
            border-radius: 24px;
        }

        .login_button_div a:hover {
            color: #ffffff;
            background-color: #202020;
        }
        .c2 {
            text-align: center;
        }
        .auto-style7 {
            width: 98%;
        }
    </style>
    <asp:Panel ID="Panel8" runat="server" Height="328px">
        <asp:Panel ID="Panel9" runat="server" Width="394px">
            <table class="auto-style7">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="Label9" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label7" runat="server" Text="รหัสบัตรประชาชน"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="รหัสผ่าน"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <div class="login_button_div">
                            <ul>
                                <li>
                                    <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click">เข้าสู่ระบบ</asp:LinkButton>
                                </li>
                            </ul>
                        </div>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </asp:Panel>
    </asp:Panel>
</asp:Content>
