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
    margin: 0 0px;
    margin-top: 5px;
    width: 60px;
    color: #c0c0c0;
    background-color: #000000;
    text-shadow: 0px 0px 0px #000000;
    border-radius: 24px;
    transition: color 0.5s ease, background-color 0.5s ease, text-shadow 0.5s ease;
        }

        .login_button_div a:hover {
    color: #ffffff;
    background-color: #cc2939;
    text-shadow: 1px 1px 16px #ffffff;
        }
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
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
            </table>

        </asp:Panel>
    </asp:Panel>
</asp:Content>
