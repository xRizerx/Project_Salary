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
            float: left;
            width: 200px;
            height: 200px;
        }

        .sec1_2 {
            float: right;
            width: 700px;
            
        }

        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            width: 160px;
        }
    </style>
    <div class="main">
        <div class="sec1">
            <div class="sec1_1">
            </div>
            <div class="sec1_2">
                <div class="master_default_div_sec">
                    <div class="master_default_div_sec_header">
                        <asp:Label ID="Label2" runat="server" Text="ข้อมูลส่วนตัว"></asp:Label>
                    </div>
                    <div class="master_default_div_sec_in">
                        <table style="width: 100%;">
                    <tr>
                        <td class="auto-style1">
                            <asp:label id="Label12" runat="server" text="รหัสบัตรประชาชน"></asp:label>
                        </td>
                        <td>
                            <asp:label id="Label14" runat="server" text="Label"></asp:label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:label id="Label13" runat="server" text="ชื่อ"></asp:label>
                        </td>
                        <td>
                            <asp:label id="Label15" runat="server" text="Label"></asp:label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:label id="Label16" runat="server" text="นามสกุล"></asp:label>
                        </td>
                        <td>
                            <asp:label id="Label17" runat="server" text="Label"></asp:label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:label id="Label21" runat="server" text="สถานะ"></asp:label>
                        </td>
                        <td>
                            <asp:label id="Label22" runat="server" text="Label"></asp:label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:label id="Label23" runat="server" text="ตำแหน่ง"></asp:label>
                        </td>
                        <td>
                            <asp:label id="Label24" runat="server" text="Label"></asp:label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
                            <asp:LinkButton ID="LinkButton11" runat="server" CssClass="master_default_button">แก้ไขข้อมูล</asp:LinkButton>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                    </div>
                </div>
                

                <div class="master_default_div_sec">
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
                        <td class="auto-style2">
                            &nbsp;</td>
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
