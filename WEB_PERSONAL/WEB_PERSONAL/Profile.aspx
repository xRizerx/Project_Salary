<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WEB_PERSONAL.Profile" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .main {
            padding: 20px;
        }

        .sec1 {
            height: 800px;
        }

        .sec1_1 {
            padding: 20px;
            margin-top: 20px;
            float: left;
            width: 200px;
            height: 200px;
            background-color: #f0f0f0;
            box-shadow: #e0e0e0 0px 5px 5px;
        }

        .sec1_1 img {
            width: 200px;
            height: 200px;
        }

        .sec1_2 {
            float: right;
            width: 720px;
            height: 800px;
        }
        #msec1 {
            background-image: url("Image/paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }
        #msec2 {
            background-image: url("Image/paper.jpg");
            background-size: cover;
            background-repeat: no-repeat;
        }

        .auto-style2 {
            width: 160px;
        }
    </style>
    <div class="main">
        <div class="sec1">
            <div class="sec1_1">
                <img src="Image/roka.gif" />
            </div>
            <div class="sec1_2">
                <div class="master_default_div_sec" id="msec1">
                    <div class="master_default_div_sec_header">
                        <asp:Label ID="Label2" runat="server" Text="ข้อมูลส่วนตัว"></asp:Label>
                    </div>
                    <div class="master_default_div_sec_in">
                        <table style="width: 100%;">
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label12" runat="server" Text="รหัสบัตรประชาชน"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label13" runat="server" Text="ชื่อ"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label16" runat="server" Text="นามสกุล"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label21" runat="server" Text="สถานะ"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label23" runat="server" Text="ตำแหน่ง"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_default_button" OnClick="LinkButton11_Click">แก้ไขข้อมูล</asp:LinkButton>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </div>
                </div>


                <div class="master_default_div_sec" id="msec2">
                    <div class="master_default_div_sec_header">
                        <asp:Label ID="Label1" runat="server" Text="เปลี่ยนรหัสผ่าน"></asp:Label>
                    </div>
                    <div class="master_default_div_sec_in">
                        <table style="width: 100%;">
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label18" runat="server" Text="รหัสผ่านเก่า"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="master_default_textbox" TextMode="Password"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label19" runat="server" Text="รหัสผ่านใหม่"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="master_default_textbox" TextMode="Password"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label20" runat="server" Text="ยืนยันรหัสผ่านใหม่"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="master_default_textbox" TextMode="Password"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2">&nbsp;</td>
                                <td>
                                    <asp:LinkButton ID="LinkButton12" runat="server" CssClass="master_default_button" OnClick="LinkButton12_Click">เปลี่ยนรหัสผ่าน</asp:LinkButton>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </div>
                </div>



            </div>
        </div>
    </div>
</asp:Content>
