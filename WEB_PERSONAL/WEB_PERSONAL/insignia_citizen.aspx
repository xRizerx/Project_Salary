<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="insignia_citizen.aspx.cs" Inherits="WEB_PERSONAL.insignia_main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 100%;
            height: 463px;
        }
        .auto-style4 {
            height: 232px;
        }
        .auto-style8 {
            width: 20px;
            height: 2px;
        }
        .auto-style9 {
            height: 2px;
        }
        .auto-style10 {
            width: 368px;
        }
        .auto-style11 {
            width: 707px;
        }
        .auto-style12 {
            height: 174px;
        }
        .auto-style15 {
            height: 2px;
            width: 486px;
        }
        .auto-style19 {
            width: 20px;
        }
        .auto-style22 {
            width: 486px;
        }
        .auto-style23 {
            text-align: center;
            width: 486px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel8" runat="server" Height="810px">
        &nbsp;<table class="auto-style3">
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style11">&nbsp;
                    <fieldset style="width:300px" class="auto-style12">
<legend><b>การจัดการเครื่องราชอิสริยาภรณ์</b></legend>

                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td class="auto-style22">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td class="auto-style23">
                                    <asp:Label ID="Label8" runat="server" Text="กรอกเลขบัตรประจำตัวประชาชน 13 หลัก"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td class="auto-style23">
                                    <asp:TextBox ID="TextBox1" style="text-align:center" runat="server" Height="27px" Width="247px" MaxLength="13" CssClass="auto-style4"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style8"></td>
                                <td class="auto-style15"></td>
                                <td class="auto-style9"></td>
                            </tr>
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td class="auto-style23">
                                    <asp:Button ID="Button1" runat="server" Text="ตกลง" Width="102px" OnClick="Button1_Click" />
                                    &nbsp;
                                    <asp:Button ID="Button2" runat="server" Text="ยกเลิก" Width="102px" OnClick="Button2_Click" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style19">&nbsp;</td>
                                <td class="auto-style22">&nbsp;</td>
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
