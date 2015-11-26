<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WEB_PERSONAL.Profile" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="CSS/Profile.css" rel="stylesheet" />
    <div class="main">
        <div class="sec1">

                <table>
                    <tr>
                        <td>
                            <div class="sec1_1">
                                <img id="profile_pic" runat="server" src="Image/roka.gif" style="object-fit: contain;" />

                            </div>
                        </td>
                        <td>
                            <div>
                                <asp:Label ID="Label2" runat="server" Text="ข้อมูลผู้ใช้งาน" CssClass="title_a"></asp:Label>
                            </div>
                            <table class="auto-style3">
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
                                <tr>
                                    <td class="auto-style2">&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        
                    </tr>
                </table>







           
        </div>

        <div>
            <asp:Label ID="Label3" runat="server" Text="รูปภาพ"></asp:Label>
            <span style="display: inline-block; width: 50px"></span>
            <asp:FileUpload ID="FileUpload1" runat="server" Width="193px" />
            <asp:LinkButton ID="LinkButton1" runat="server" Text="อัพโหลด" CssClass="master_default_button" OnClick="LinkButton1_Click"></asp:LinkButton>
            
        </div>

        <asp:Panel ID="Panel1" runat="server"></asp:Panel>

  

    </div>
</asp:Content>
