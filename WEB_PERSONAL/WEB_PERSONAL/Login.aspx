<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WEB_PERSONAL.CSS.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 141px;
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

            
            text-align: left;
            /*border-radius: 32px;*/
            background-color: #c8c8c8;
            background-image: url("Image/ef333.jpg");
            background-size: cover;
            background-repeat: no-repeat;
            /*background-attachment:fixed;*/
            width: 600px;
            width: 100%;
        }
        .fade {
            background-color: rgba(0,0,0,0.3);
            text-align: left;
            /*border-radius: 32px;*/
            padding: 20px 100px;
        }
        .bb {
            margin: 0 auto;
            text-align: center;
            padding: 20px 0;
            /*background-color: #c8c8c8;
            background-image: url("Image/DORAEMON.jpg");
            background-size: cover;
            background-repeat: no-repeat;*/
        }

        .c10 {
            color: #ffffff;
            text-shadow: 1px 1px 1px #000000;
        }
        .c11 {
            color: #ff0000;
            text-shadow: 1px 1px 1px #000000;
        }
        

        .auto-style9 {
            width: 146px;
            height: 29px;
        }

        .auto-style15 {
            width: 141px;
            text-align: right;
        }
        .auto-style16 {
            width: 207px;
        }
        .auto-style17 {
            width: 146px;
        }
    </style>
    <asp:Panel ID="Panel8" runat="server" Height="800px" CssClass="bb">



        <br />
        <asp:Label ID="Label1" runat="server" Text="เข้าสู่ระบบ" Font-Size="32"></asp:Label>
        <br />
        <br />
        <div class="login_pan">
            <div class="fade">
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style5"></td>
                        <td class="auto-style9">
                            <asp:Label ID="Label9" runat="server" CssClass="c11"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label7" runat="server" Text="รหัสบัตรประชาชน" CssClass="c10"></asp:Label>
                        </td>
                        <td class="auto-style17">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">
                            <asp:Label ID="Label8" runat="server" Text="รหัสผ่าน" CssClass="c10"></asp:Label>
                        </td>
                        <td class="auto-style17">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="master_default_textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style17">

                            <asp:LinkButton ID="LinkButton10" runat="server" OnClick="LinkButton10_Click" CssClass="master_default_button">เข้าสู่ระบบ</asp:LinkButton>


                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style15">&nbsp;</td>
                        <td class="auto-style17">&nbsp;</td>
                    </tr>
                </table>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
