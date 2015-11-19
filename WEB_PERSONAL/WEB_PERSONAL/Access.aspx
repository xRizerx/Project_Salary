<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Access.aspx.cs" Inherits="WEB_PERSONAL.Access" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <link rel="icon" href="Image/favicon.ico" />
    <title>ระบบบุคลากร - มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก วิทยาเขตบางพระ</title>
    <link rel="stylesheet" type="text/css" href="CSS/Master.css" />
    <link href="CSS/Access.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        

        <div class="login_popup">

            <div class="login_popup_in">
                <div class="login_popup_div_sec">
                    <div class="login_popup_div_sec_header">
                        <asp:Label ID="Label11" runat="server" Text="เข้าสู่ระบบ บุคลากร"></asp:Label>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="มหาวิทยาลัยเทคโนโลยีราชมงคลตะวันออก วิทยาเขตบางพระ"></asp:Label>
                    </div>
                    <div class="login_popup_div_sec_in">
                        <asp:Panel ID="Panel1" runat="server" DefaultButton="LinkButton1X">
                            <table>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="Label12X" runat="server" CssClass="cerror"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label13X" runat="server" Text="รหัสบัตรประชาชน" CssClass="c10"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox1X" runat="server" CssClass="master_default_textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label14X" runat="server" Text="รหัสผ่าน" CssClass="c10"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="TextBox2X" runat="server" TextMode="Password" CssClass="master_default_textbox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label15X" runat="server" CssClass="c10" Text="คงอยู่ในระบบ"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="DropDownList1X" runat="server" CssClass="master_default_dropdown">
                                            <asp:ListItem Value="300">5 นาที</asp:ListItem>
                                            <asp:ListItem Value="1800">30 นาที</asp:ListItem>
                                            <asp:ListItem Value="3600">1 ชั่วโมง</asp:ListItem>
                                            <asp:ListItem Value="999999999">จนกว่าจะปิดเบราเซอร์</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>
                                        <asp:LinkButton ID="LinkButton1X" runat="server" OnClick="LinkButton1X_Click">เข้าสู่ระบบ</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                    </div>
                </div>
            </div>


        </div>
    </form>
</body>
</html>
