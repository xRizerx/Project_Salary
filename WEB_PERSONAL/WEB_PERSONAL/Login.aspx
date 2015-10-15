<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB_PERSONAL.CSS.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        width: 187px;
    }
    .auto-style3 {
        width: 48px;
    }
    .auto-style4 {
        width: 48px;
        height: 53px;
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
    </style>
    <asp:Panel ID="Panel8" runat="server" Height="328px">
        <table style="width:100%;">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="รหัสบัตรประชาชน"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="รหัสผ่าน"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
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
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
