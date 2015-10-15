<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_main.aspx.cs" Inherits="WEB_PERSONAL.insignia_main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            height: 463px;
        }
        .auto-style4 {
            height: 232px;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            width: 29px;
        }
        .auto-style8 {
            width: 29px;
            height: 2px;
        }
        .auto-style9 {
            height: 2px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel8" runat="server" Height="810px">
        &nbsp;<table class="auto-style3">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;
                    <fieldset style="300px" class="auto-style4">
<legend><b>การจัดการเครื่องราชอิสริยาภรณ์</b></legend>

                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td class="auto-style6">
                                    <asp:Label ID="Label8" runat="server" Text="กรอกเลขบัตรประจำตัวประชาชน 13 หลัก"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="TextBox1" style="text-align:center" runat="server" Height="27px" Width="247px" MaxLength="13" CssClass="auto-style4"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style8"></td>
                                <td class="auto-style9"></td>
                                <td class="auto-style9"></td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td class="auto-style6">
                                    <asp:Button ID="Button1" runat="server" Text="ตกลง" Width="102px" OnClick="Button1_Click" />
                                    &nbsp;
                                    <asp:Button ID="Button2" runat="server" Text="ยกเลิก" Width="102px" OnClick="Button2_Click" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style7">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>

</fieldset>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
